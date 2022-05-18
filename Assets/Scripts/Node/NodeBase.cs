using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NodeBase : MonoBehaviour
{
    // 階層
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    // しきい値
    [SerializeField] int _threshold;
    public int Threshold { get => _threshold; private set { } }
    //次のノードに進める判定
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    //Type
    [SerializeField] MaterialType _materialType;
    public MaterialType MaterialType { get => _materialType; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }

    //enumの種類
    //[SerializeReference] Enum[] _types = new Enum[3];
    //[SerializeReference] Enum _type;
    ////enumごとの要素数
    //List<int> _iDs = new List<int>();
    ////IDと所持数
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
        ////enumの数分回す
        //for (int i = 0; i < _types.Length; i++)
        //{
        //    // アイテムのIDと所持数
        //    var item = new Dictionary<int, int>();

        //    //enumのIDの数分回す
        //    for (int k = 0; k < _iDs[i]; k++)
        //    {
        //        //アイテムの最初の所持数は0なので0を初期値として入れる
        //        item.Add(k, 0);
        //    }
        //    //Dictionaryの初期化
        //    Items.Add(_types[i], item);
        //}
    }
    void Judge()
    {

    }
    void AddItems(Enum type, int id, int count)
    {
        //Dictionary<Enum, Dictionary<int, int>>()
        //                                 ↑カウントに足していく
        //Items[type][id] += count;
    }
}
