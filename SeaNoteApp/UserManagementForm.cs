using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace SeaNoteApp
{
    public partial class UserManagementForm : Form
    {
        private long selectedUserId = 0;
        private List<User> userList = new List<User>();

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsersToGrid();
            ClearUserForm();

            cbRoles.Items.Clear();
            cbRoles.Items.Add("admin");
            cbRoles.Items.Add("owner");
            cbRoles.Items.Add("engineer");
        }

        private void LoadUsersToGrid()
        {
            userList.Clear();
            dataGridViewUsers.DataSource = null;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string sql = @"SELECT user_id, username, role, nama_lengkap, email, no_handphone 
                                 FROM public.users ORDER BY created_at DESC";
                using var cmd = new NpgsqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userList.Add(new User
                    {
                        UserID = reader["user_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["user_id"]),
                        Username = reader["username"]?.ToString() ?? "",
                        Role = reader["role"]?.ToString(),
                        NamaLengkap = reader["nama_lengkap"]?.ToString(),
                        Email = reader["email"]?.ToString(),
                        NomorTelepon = reader["no_handphone"]?.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal ambil data user: " + ex.Message);
            }

            dataGridViewUsers.DataSource = userList;

            if (dataGridViewUsers.Columns.Count > 0)
            {
                if (dataGridViewUsers.Columns.Contains("UserID"))
                {
                    dataGridViewUsers.Columns["UserID"].Visible = false;
                    dataGridViewUsers.Columns["UserID"].Width = 80;
                }
                if (dataGridViewUsers.Columns.Contains("Username"))
                    dataGridViewUsers.Columns["Username"].Width = 150;
                if (dataGridViewUsers.Columns.Contains("Role"))
                    dataGridViewUsers.Columns["Role"].Width = 120;
            }
        }

        private void ClearUserForm()
        {
            tbUsername.Text = "";
            tbFullname.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            cbRoles.SelectedIndex = -1;
            selectedUserId = 0;
            dataGridViewUsers.ClearSelection();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];

            var idVal = row.Cells["UserID"].Value;
            selectedUserId = idVal == DBNull.Value ? 0L : Convert.ToInt64(idVal);

            tbUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
            tbFullname.Text = row.Cells["NamaLengkap"].Value?.ToString() ?? "";
            tbEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            tbPhone.Text = row.Cells["NomorTelepon"].Value?.ToString() ?? "";

            var roleVal = row.Cells["Role"].Value?.ToString();
            if (!string.IsNullOrEmpty(roleVal) && cbRoles.Items.Contains(roleVal))
                cbRoles.SelectedItem = roleVal;
            else
                cbRoles.SelectedIndex = -1;

            dataGridViewUsers.ClearSelection();
            row.Selected = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Username wajib diisi");
                return;
            }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string sql = @"INSERT INTO public.users 
                                 (username, password, nama_lengkap, email, no_handphone, role)
                                 VALUES (@username, @password, @nama, @email, @phone, @role)";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("username", tbUsername.Text);
                cmd.Parameters.AddWithValue("password", "changeme");
                cmd.Parameters.AddWithValue("nama", string.IsNullOrWhiteSpace(tbFullname.Text) ? (object)DBNull.Value : tbFullname.Text);
                cmd.Parameters.AddWithValue("email", string.IsNullOrWhiteSpace(tbEmail.Text) ? (object)DBNull.Value : tbEmail.Text);
                cmd.Parameters.AddWithValue("phone", string.IsNullOrWhiteSpace(tbPhone.Text) ? (object)DBNull.Value : tbPhone.Text);

                object roleValue = cbRoles.SelectedItem?.ToString() ?? (object)DBNull.Value;
                var roleParam = new NpgsqlParameter("role", NpgsqlDbType.Unknown);
                if (roleValue != DBNull.Value)
                {
                    roleParam.DataTypeName = "user_role";
                    roleParam.Value = roleValue;
                }
                else
                {
                    roleParam.Value = DBNull.Value;
                }
                cmd.Parameters.Add(roleParam);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User baru berhasil ditambah (pass default: changeme)");
                LoadUsersToGrid();
                ClearUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah user: " + ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Pilih user dulu");
                return;
            }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string sql = @"UPDATE public.users
                                 SET username = @username,
                                     nama_lengkap = @nama,
                                     email = @email,
                                     no_handphone = @phone,
                                     role = @role,
                                     updated_at = now()
                                 WHERE user_id = @user_id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("username", tbUsername.Text);
                cmd.Parameters.AddWithValue("nama", string.IsNullOrWhiteSpace(tbFullname.Text) ? (object)DBNull.Value : tbFullname.Text);
                cmd.Parameters.AddWithValue("email", string.IsNullOrWhiteSpace(tbEmail.Text) ? (object)DBNull.Value : tbEmail.Text);
                cmd.Parameters.AddWithValue("phone", string.IsNullOrWhiteSpace(tbPhone.Text) ? (object)DBNull.Value : tbPhone.Text);

                object roleValue = cbRoles.SelectedItem?.ToString() ?? (object)DBNull.Value;
                var roleParam = new NpgsqlParameter("role", NpgsqlDbType.Unknown);
                if (roleValue != DBNull.Value)
                {
                    roleParam.DataTypeName = "user_role";
                    roleParam.Value = roleValue;
                }
                else
                {
                    roleParam.Value = DBNull.Value;
                }
                cmd.Parameters.Add(roleParam);

                cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Bigint) { Value = selectedUserId });

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data user berhasil di-update");
                LoadUsersToGrid();
                ClearUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update user: " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Pilih user dulu");
                return;
            }

            if (MessageBox.Show("Yakin mau hapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand("DELETE FROM public.users WHERE user_id = @user_id", conn);
                cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Bigint) { Value = selectedUserId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("User berhasil dihapus");
                LoadUsersToGrid();
                ClearUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hapus user: " + ex.Message);
            }
        }

        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { MessageBox.Show("Pilih user dulu"); return; }
            if (cbRoles.SelectedItem == null) { MessageBox.Show("Pilih role"); return; }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand("UPDATE public.users SET role = @role, updated_at = now() WHERE user_id = @user_id", conn);

                string roleValue = cbRoles.SelectedItem.ToString();
                var roleParam = new NpgsqlParameter("role", NpgsqlDbType.Unknown)
                {
                    DataTypeName = "user_role",
                    Value = roleValue
                };
                cmd.Parameters.Add(roleParam);

                cmd.Parameters.Add(new NpgsqlParameter("user_id", NpgsqlDbType.Bigint) { Value = selectedUserId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("Role berhasil diassign");
                LoadUsersToGrid();
                ClearUserForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal assign role: " + ex.Message);
            }
        }
    }
}