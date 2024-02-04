using Npgsql;
using System.Data;

namespace App.components
{
    public class Database
    {
        private Config _config;

        public NpgsqlConnection _conn;

        public Database() 
        {
            _config = new Config();

            _conn = new NpgsqlConnection(_config.get_SetUp());

            _conn.Open();
        }

        public bool IsAdmin(string login)
        {
            bool is_admin = false;

            string commandText = $"SELECT roles_id FROM users WHERE login = '{login}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        is_admin = reader[0].ToString() == "5";
                    }
            }

            return is_admin;
        }

        public bool IsLogin(string login, string password) 
        {
            bool is_login = false;

            string commandText = $"SELECT login FROM users WHERE login = '{login}' AND passwords = '{password}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        is_login = reader[0].ToString() != "";
                    }
            }

            return is_login;
        }

        public bool IsLoginIn(string login)
        {
            bool is_login = false;

            string commandText = $"SELECT login FROM users WHERE login = '{login}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        is_login = reader[0].ToString() != "";
                    }
            }

            return is_login;
        }

        public List<string> Roles()
        {
            List<string> roles = new List<string>();

            string commandText = $"SELECT * FROM roles;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        roles.Add(reader.GetString(reader.GetOrdinal("rols")));
                    }
            }

            return roles;
        }

        public void RegistUser(string login, string role, string password, string last_name, string first_name)
        {
            int role_id = 1;

            string commandText = $"SELECT id FROM roles WHERE rols = '{role}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        role_id = int.Parse(reader[0].ToString());
                    }
            }

            commandText = $"INSERT INTO users (roles_id, login, first_name, last_name, passwords) VALUES ({role_id}, '{login}', '{first_name}', '{last_name}', '{password}');";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                }
            }

        }
    }
}
