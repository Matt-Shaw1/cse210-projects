using System.IO;
using System.Text.Json;

public class StorageService
{
    public void SaveData<T>(string filename, T data)
    {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(filename, jsonString);
    }

    public T LoadData<T>(string filename)
    {
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        return default(T);
    }
}
