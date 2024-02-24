using System.Data;
using Npgsql;

namespace App.components.database
{
    public class Database
    {
        private Config _config;

        private NpgsqlConnection _conn;

        public Database()
        {
            _config = new Config();

            _conn = new NpgsqlConnection(_config.get_SetUp());
        }

        public DataTable Table(string table)
        {
            DataTable dt = new DataTable();

            _conn.Open();

            string commandText = $"SELECT * FROM {table} LIMIT 20;";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    _conn.Close();

                    return dt;
                }
            }
        }

        public List<string> Roles()
        {
            _conn.Open();

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

            _conn.Close();

            return roles;
        }

        public int GetidRole(string role)
        {
            _conn.Open();

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

            _conn.Close();

            return role_id;
        }

        public int GetidUser(string login)
        {
            _conn.Open();

            int user_id = 1;

            string commandText = $"SELECT id FROM users WHERE login = '{login}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        user_id = int.Parse(reader[0].ToString());
                    }
            }

            _conn.Close();

            return user_id;
        }

        public bool IsAdmin(string login)
        {
            _conn.Open();

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

            _conn.Close();

            return is_admin;
        }

        public bool IsLogin(string login, string password)
        {
            _conn.Open();

            bool is_login = false;

            string commandText = $"SELECT login FROM users WHERE login = '{login}' AND passwords = md5('{password}');";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        is_login = reader[0].ToString() != "";
                    }
            }

            _conn.Close();

            return is_login;
        }

        public bool IsLoginIn(string login)
        {
            _conn.Open();

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

            _conn.Close();

            return is_login;
        }

        public void RegistUser(string login, string role, string password, string last_name, string first_name)
        {
            int role_id = GetidRole(role);

            _conn.Open();

            string commandText = $"INSERT INTO users (roles_id, login, first_name, last_name, passwords) VALUES ({role_id}, '{login}', '{first_name}', '{last_name}', md5('{password}'));";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                }
            }

            _conn.Close();

        }

        public void DropUser(string login)
        {
            _conn.Open();

            string commandText = $"DELETE FROM users WHERE login = '{login}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                }
            }

            _conn.Close();
        }

        public void UpdateRole(string login, string role)
        {
            int role_id = GetidRole(role);

            _conn.Open();

            string commandText = $"UPDATE users SET roles_id = {role_id} WHERE login = '{login}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                }
            }

            _conn.Close();
        }

        public void NewPassword(string login, string password)
        {
            _conn.Open();

            string commandText = $"UPDATE users SET passwords = md5('{password}') WHERE login = '{login}';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                }
            }
        }

        public void Add(string table, string value)
        {
            _conn.Open();

            List<string> values = new List<string>();

            string commandText = $"SELECT column_name FROM information_schema.columns WHERE table_name = '{table}' AND column_name != 'id';";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        values.Add(reader.GetString(reader.GetOrdinal("column_name")));
                    }
                }
            }

            string param = string.Join(", ", values.ToArray());

            commandText = $"INSERT INTO {table} ({param}) VALUES {value};";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, _conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                }
            }

            _conn.Close();
        }
    }
}
