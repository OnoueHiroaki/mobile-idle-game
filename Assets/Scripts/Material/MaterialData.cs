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
    [SerializeField] List<Material> _data;
    //ƒf[ƒ^‚ðŽæ‚Á‚Ä‚­‚é
    public Material GetData(int id) => _data[id];
}
[System.Serializable]
public class Material
{
    [SerializeField] string _name;
    [SerializeField] int _id;
    //[SerializeField] int _count;
    [SerializeField] int _maxScore;
    [SerializeField] int _minScore;
    //Ží—Þ
    [SerializeField] MaterialType _type;
    [SerializeField] GameObject _object;
    public string Name { get=> _name; set { } }
    public int ID { get => _id; set { } }
    public int MaxScore { get => _maxScore; set { } }
    public int MinScore { get => _minScore; set { } }
    public MaterialType Type { get => _type; set { } }
    public GameObject Object { get => _object; set { } }
}
