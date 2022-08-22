using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInfo : MonoBehaviour
{
    [SerializeField] MaterialData _materialData;
    Material _data;
    [SerializeField] int _score;
    public Material Data { get => _data; set { } }
    public int Score { get => _score; set { } }

    UnityEngine.UI.Button _button;
    private void Start()
    {
        SetUp(_materialData.GetData(0));
    }
    //このオブジェクトを生成するタイミングで呼ぶ
    public void SetUp(Material material)
    {
        _data = material;
        _score = Random.Range(_data.MinScore, _data.MaxScore + 1);
    }
}
