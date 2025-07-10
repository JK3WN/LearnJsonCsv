using System.IO;
using System.Text;
using UnityEngine;
using Newtonsoft.Json;

public class JsonSaveLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FileStream stream = new FileStream(Application.dataPath + "/test.json", FileMode.OpenOrCreate);
        JsonTestClass jTest1 = new JsonTestClass();
        string jsonData = JsonConvert.SerializeObject(jTest1, Formatting.Indented);
        byte[] data = Encoding.UTF8.GetBytes(jsonData);
        stream.Write(data, 0, data.Length);
        stream.Close();

        //FileStream stream = new FileStream(Application.dataPath + "/test.json", FileMode.OpenOrCreate);
        //byte[] data = new byte[stream.Length];
        //stream.Read(data, 0, data.Length);
        //stream.Close();
        //string jsonData = Encoding.UTF8.GetString(data);
        //JsonTestClass jTest2 = JsonConvert.DeserializeObject<JsonTestClass>(jsonData);
        //jTest2.Print();
    }
}
