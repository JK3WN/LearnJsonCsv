using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonUtilityExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //JsonTestClass jTest1 = new JsonTestClass();
        //string jsonData = JsonUtility.ToJson(jTest1, true);
        //Debug.Log(jsonData);

        //JsonTestClass jTest2 = JsonUtility.FromJson<JsonTestClass>(jsonData);
        //jTest2.Print();

        //JsonVector jVector = new JsonVector();
        //string jsonData = JsonUtility.ToJson(jVector, true);
        //Debug.Log(jsonData);

        GameObject obj = new GameObject();
        var test1 = obj.AddComponent<TestMono>();
        test1.i = 100;
        test1.v3 /= 10;
        string jsonData = JsonUtility.ToJson(obj.GetComponent<TestMono>(), true);
        Debug.Log(jsonData);

        GameObject obj2 = new GameObject();
        JsonUtility.FromJsonOverwrite(jsonData, obj2.AddComponent<TestMono>());
    }
}
