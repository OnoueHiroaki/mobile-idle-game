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
    //ID‚Ì”»’è‚ð‚·‚éˆ×‚ÉŽæ‚Á‚Ä‚­‚éŠÖ”
    public MaterialType GetType(int num) => _types[num];
    //ƒf[ƒ^‚ðŽæ‚Á‚Ä‚­‚é
    public Material GetData(int num) => _data[num];
}
[System.Serializable]
public class Material
{
    [SerializeField] string _name;
    [SerializeField] int _iD;
    [SerializeField] int _count;
    [SerializeField] int _score;
    //Ží—Þ
    [SerializeField] MaterialType _materialType;
}
