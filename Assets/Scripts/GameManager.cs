using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    //[SerializeField] TestData _testData;
    //string _dataFile;
    private void Awake()
    {
        Instance = this;
        //_dataFile = Application.dataPath + "/TestData.json";
    }
    private void Start()
    {
        //_testData.Name = "aha";
        //_testData.Score = 50;
        //var json = JsonUtility.ToJson(_testData);
        //StreamWriter writer = new StreamWriter(_dataFile,false);
        //writer.WriteLine(json);
        //writer.Flush();

    }
}
