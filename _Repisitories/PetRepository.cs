using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_MPham.Models;

namespace web_MPham._Repisitories
{
    internal class PetRepository : BaseRepository, IPetRepository
    {
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Login(string username, string password)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Account WHERE Username = @u AND Password = @p", conn))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@p", SqlDbType.NVarChar).Value = password;

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public void Register(Accounts account)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = @"INSERT INTO Account (accountID, username, password, phoneNumber, fullName, birthday, status, position, addresss)
                                 VALUES (@accountID, @username, @password, @phoneNumber, @fullname, @birthday, @status, @position, @address)";
                cmd.Parameters.AddWithValue("accountID", account.accountID);
                cmd.Parameters.AddWithValue("@username", account.Username);
                cmd.Parameters.AddWithValue("@password", account.Password);
                cmd.Parameters.AddWithValue("@phoneNumber", account.phoneNumber);
                cmd.Parameters.AddWithValue("@fullName", account.fullName);
                cmd.Parameters.AddWithValue("@birthday", account.birthday);
                cmd.Parameters.AddWithValue("@status", account.status);
                cmd.Parameters.AddWithValue("@position", account.position);
                cmd.Parameters.AddWithValue("@address", account.address);

                cmd.ExecuteNonQuery();
            }
        }
        public string GenerateNextAccount()
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT MAX(accountID) FROM Account WHERE accountID LIKE @prefix", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@prefix", "CM%");
                var result = cmd.ExecuteScalar()?.ToString();
                if (string.IsNullOrEmpty(result))
                    return "CM01";

                string numberP = result.Substring(2);
                int nextNumber = int.Parse(numberP) + 1;
                return "CM" + nextNumber.ToString("D2");
            }
        }
    }
}
