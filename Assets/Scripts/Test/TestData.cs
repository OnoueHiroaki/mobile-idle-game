using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TestData : MonoBehaviour
{
    [SerializeField] string _name;
    [SerializeField] int _score;
    public string Name { get => _name; set { } }

    public int Score { get => _score; set { } }
}
