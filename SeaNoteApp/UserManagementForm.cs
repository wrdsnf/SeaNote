using SeaNote.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class UserManagementForm : Form
    {
        private int selectedUserId = -1;

        public UserManagementForm()
        {
            InitializeComponent();
        }
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsersToGrid();
        }

        private void LoadUsersToGrid()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = UserData.dummyUsers.ToList();

            if (dataGridViewUsers.Columns.Count > 0)
            {
                dataGridViewUsers.Columns["UserID"].Width = 50;
                dataGridViewUsers.Columns["NamaLengkap"].Width = 150;
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                selectedUserId = (int)row.Cells["UserID"].Value;

                string? currentRole = row.Cells["Role"].Value?.ToString();
                cbRoles.SelectedItem = currentRole;
            }
            else
            {
                selectedUserId = -1;
                cbRoles.SelectedIndex = -1;
            }
        }

        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Pilih user dari tabel dulu!");
                return;
            }
            if (cbRoles.SelectedItem == null)
            {
                MessageBox.Show("Pilih role yang mau di-assign!");
                return;
            }

            try
            {
                User? userToUpdate = UserData.dummyUsers.Find(u => u.UserID == selectedUserId);

                if (userToUpdate != null)
                {
                    userToUpdate.Role = cbRoles.SelectedItem.ToString();

                    MessageBox.Show($"Role untuk user '{userToUpdate.Username}' berhasil diubah menjadi '{userToUpdate.Role}'.");
                    LoadUsersToGrid();
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal assign role: " + ex.Message);
            }
        }
    }
}

