using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ExcelReader : MonoBehaviour
{
    public string csvFileName = "Menu";
    public Dictionary<string, Menu> dicMenu = new Dictionary<string, Menu>();
    [System.Serializable]
    public class Menu
    {
        public string name;
        public string price;
        public string description;
    }

    private void Start()
    {
        ReadCSV();
    }

    void ReadCSV()
    {
        string path = "Menu.csv";
        List<Menu> menuList = new List<Menu>();
        StreamReader reader = new StreamReader(Application.dataPath + "/" + path);
        bool isFinish = false;
        while (!isFinish)
        {
            string data = reader.ReadLine();
            if(data == null)
            {
                isFinish = true;
                break;
            }
            var splitData = data.Split(',');
            Menu menu = new Menu();
            menu.name = splitData[1];
            menu.price = splitData[2];
            menu.description = splitData[3];
            dicMenu.Add(splitData[0], menu);
            Debug.Log(menu.name);
            Debug.Log(dicMenu.Count);
        }
        Debug.Log(dicMenu["Sandvich"].name);
    }
}
