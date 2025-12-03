using Npgsql;
using System;
using System.Data;

namespace SeaNoteWPF.Utils
{
    public static class MessageService
    {
        public static void SendMessage(long senderId, string targetRole, string body)
        {
            SaveToDb(senderId, targetRole, body);
        }

        public static void SendSystemAlert(string targetRole, string body)
        {
            SaveToDb(0, targetRole, body);
        }

        private static void SaveToDb(long senderId, string role, string msg)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "INSERT INTO public.messages (sender_id, receiver_role, message_body, created_at) VALUES (@uid, @role, @msg, NOW())";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("uid", senderId);
                cmd.Parameters.AddWithValue("role", role);
                cmd.Parameters.AddWithValue("msg", msg);
                cmd.ExecuteNonQuery();
            }
            catch { /* Silent fail kalo DB error */ }
        }

        public static DataTable GetMyMessages(string myRole)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var sql = @"
                SELECT 
                    m.message_body, 
                    m.created_at, 
                    COALESCE(u.username, '⚠️ SYSTEM ALERT') as sender 
                FROM public.messages m
                LEFT JOIN public.users u ON m.sender_id = u.user_id
                WHERE (m.receiver_role = @role OR m.receiver_role = 'All')
                ORDER BY m.created_at DESC 
                LIMIT 50";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("role", myRole);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            return dt;
        }
    }
}