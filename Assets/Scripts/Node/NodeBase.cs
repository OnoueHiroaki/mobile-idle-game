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
    // 階層
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    // しきい値
    [SerializeField] int _threshold;
    public int Threshold { get => _threshold; private set { } }
    //次のノードに進める判定
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //enumの種類
    Enum[] types = new Enum[3];
    Dictionary<Enum, Dictionary<int, int>> Items = new Dictionary<Enum, Dictionary<int, int>>();
}
