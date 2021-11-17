using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] TestData _testData;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _testData.Name = "aha";
        _testData.Score = 50;
        var json = JsonUtility.ToJson(_testData);
    }
}
