using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using System.Xml.Serialization;

public interface StorageServise

{
    void Save(string key, object data);
    T Load<T>(string key);
}

public class JsonStorageService : StorageServise
{
    public void Save(string key, object data){
        try{
            CreateFileIfNotExist(key);
            key = BuildPath(key);
            using(StreamWriter writer = new StreamWriter(key)){
                writer.Write(JsonConvert.SerializeObject(data));
            }
        }
        catch(Exception ex){
            Debug.Log(ex.Message);
        }
    }

    public T Load<T>(string key)
    {
        try
        {
            CreateFileIfNotExist(key);
            using (StreamReader reader = new StreamReader(BuildPath(key)))
            {
                return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
            return default(T);
        }
    }
    private string BuildPath(string key){
        return Path.Combine(Application.persistentDataPath, key + ".json");
    }

    private void CreateFileIfNotExist(string key){
        string path = BuildPath(key);
        if (!File.Exists(path)){
            File.Create(path).Close();
        }
    }
}  