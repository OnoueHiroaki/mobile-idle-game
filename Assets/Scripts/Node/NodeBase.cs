using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NodeBase : MonoBehaviour
{
    // �K�w
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    // �������l
    [SerializeField] int _threshold;
    public int Threshold { get => _threshold; private set { } }
    //���̃m�[�h�ɐi�߂锻��
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    //Type
    [SerializeField] MaterialType _materialType;
    public MaterialType MaterialType { get => _materialType; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }

    //enum�̎��
    //[SerializeReference] Enum[] _types = new Enum[3];
    //[SerializeReference] Enum _type;
    ////enum���Ƃ̗v�f��
    //List<int> _iDs = new List<int>();
    ////ID�Ə�����
    //Dictionary<Enum, Dictionary<int, int>> Items = new Dictionary<Enum, Dictionary<int, int>>();
    private void Start()
    {
        InitIDs();
    }
    void InitIDs()
    {
        //_types[0] = (GrassType)0;
        //_types[1] = (OreType)0;
        //_types[2] = (WaterType)0;
        //_iDs.Add(Enum.GetValues(typeof(GrassType)).Length);
        //_iDs.Add(Enum.GetValues(typeof(OreType)).Length);
        //_iDs.Add(Enum.GetValues(typeof(WaterType)).Length);
        ////enum�̐�����
        //for (int i = 0; i < _types.Length; i++)
        //{
        //    // �A�C�e����ID�Ə�����
        //    var item = new Dictionary<int, int>();

        //    //enum��ID�̐�����
        //    for (int k = 0; k < _iDs[i]; k++)
        //    {
        //        //�A�C�e���̍ŏ��̏�������0�Ȃ̂�0�������l�Ƃ��ē����
        //        item.Add(k, 0);
        //    }
        //    //Dictionary�̏�����
        //    Items.Add(_types[i], item);
        //}
    }
    void Judge()
    {

    }
    void AddItems(Enum type, int id, int count)
    {
        //Dictionary<Enum, Dictionary<int, int>>()
        //                                 ���J�E���g�ɑ����Ă���
        //Items[type][id] += count;
    }
}
