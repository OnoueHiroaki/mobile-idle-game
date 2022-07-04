using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInfo : MonoBehaviour
{
    Material _data;
    [SerializeField] int _score;
    private void Start()
    {
       
    }
    public void SetUp(Material mat) 
    {
        _data = mat;
        _score = Random.Range(_data.MinScore, _data.MaxScore);
    }
}
