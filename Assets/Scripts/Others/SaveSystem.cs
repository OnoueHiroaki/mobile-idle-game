using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : UnityEngine.MonoBehaviour
{
    string _dataPath;
    private void Awake()
    {
        _dataPath = Application.dataPath + "TestJson.json";
    }
    private void Start()
    {
        TestData save1 = new TestData();
        save1.Name = "aaa";
        save1.HP = 10;
        save1.Time = System.DateTime.Now.ToString();
        string json = JsonUtility.ToJson(save1);
        Debug.Log(json);
        SaveTest(save1);
        TestData save2 = LoadTest(_dataPath);
        Debug.Log(save2);
    }
    public void SaveTest(TestData testData)
    {
        string jsonstr = JsonUtility.ToJson(testData);
        StreamWriter writer = new StreamWriter(_dataPath, false);
        writer.WriteLine(jsonstr);
        writer.Flush(); 
        writer.Close();
    }
    TestData LoadTest(string dataPath)
    {
        StreamReader reader = new StreamReader(dataPath,false);
        string data = reader.ReadToEnd(); 
        return JsonUtility.FromJson<TestData>(data);
    }
}