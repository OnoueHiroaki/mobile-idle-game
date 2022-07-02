using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInfo : MonoBehaviour
{
    [SerializeField] int _id;
    [SerializeField] MaterialData _data;
    [SerializeField] int _score;
    private void Start()
    {
        _score = Random.Range(_data.GetData(_id).MinScore, _data.GetData(_id).MaxScore);
        Debug.Log(_score);
    }
}
