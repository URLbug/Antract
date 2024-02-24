using System.Text.Json;

namespace App.components.jsons
{
    public class Sessions
    {
        public void JsonWrite(string path, object data)
        {
            string json = JsonSerializer.Serialize(data);

            File.WriteAllText(path, json);
        }

        public T? JsonRead<T>(string path)
        {
            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(json);
        }
    }

    public class UserSession
    {
        public int Id { get; set; }
        public string Username { get; set; }

    }
}
