using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MaterialType
{
    Grass,
    Ore,
    Water,
}
[CreateAssetMenu(fileName = "MaterialData")]
public class MaterialData : ScriptableObject
{
    [SerializeField] List<MaterialType> _types;
    [SerializeField] List<Material> _data;
    //IDの判定をする為に取ってくる関数
    public MaterialType GetType(int num) => _types[num];
    //データを取ってくる
    public Material GetData(int num) => _data[num];
}
[System.Serializable]
public class Material
{
    [SerializeField] string _name;
    [SerializeField] int _iD;
    [SerializeField] int _count;
    [SerializeField] int _score;
    //種類
    [SerializeField] MaterialType _materialType;
}
