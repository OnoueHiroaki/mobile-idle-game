using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public enum NodeType
{
    Person,
}
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
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //enum�̎��
    Enum[] _types = new Enum[3];
    //enum���Ƃ̗v�f��
    List<int> _iDs = new List<int>();
    //ID�Ə�����
    Dictionary<Enum, Dictionary<int, int>> Items = new Dictionary<Enum, Dictionary<int, int>>();
    private void Start()
    {
        _types[0] = (GrassType)0;
        _types[1] = (OreType)0;
        _types[2] = (WaterType)0;
        _iDs.Add();
        //enum�̐�����
        for (int i = 0; i < _types.Length; i++)
        {
            // �A�C�e����ID�Ə�����
            var item = new Dictionary<int, int>();
            
            //enum��ID�̐�����
            for (int k = 0; k < _iDs[i]; k++)
            {
                //�A�C�e���̍ŏ��̏�������0�Ȃ̂�0�������l�Ƃ��ē����
                item.Add(k, 0);
            }
            //Dictionary�̏�����
            Items.Add(_types[i], item);
        }
    }
}
