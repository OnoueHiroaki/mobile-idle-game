using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum MaterialType
{
    GreenGrass,
    RedGrass,
    Iron,
    Water,
}
[CreateAssetMenu(fileName = "MaterialData")]
public class MaterialData : ScriptableObject
{
    [SerializeField] List<MaterialType> _types;
    [SerializeField] List<Material> _data;
    //ID�̔��������ׂɎ���Ă���֐�
    public MaterialType GetType(int num) => _types[num];
    //�f�[�^������Ă���
    public Material GetData(int num) => _data[num];
}
[System.Serializable]
public class Material
{
    [SerializeField] int _iD;
    [SerializeField] int _count;
    [SerializeField] int _score;
}