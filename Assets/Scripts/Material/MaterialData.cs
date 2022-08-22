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
    [SerializeField] int _maxScore;
    [SerializeField] int _minScore;
    //Ží—Þ
    [SerializeField] MaterialType _type;
    [SerializeField] GameObject _object;
    [SerializeField] Sprite _sprite;
    public string Name  => _name; 
    public int ID => _id;
    public int MaxScore => _maxScore;
    public int MinScore => _minScore;
    public MaterialType Type => _type; 
    public GameObject Object => _object; 
    public Sprite Sprite => _sprite;
}
