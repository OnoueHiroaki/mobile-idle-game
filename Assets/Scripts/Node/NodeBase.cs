using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NodeBase 
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
    //Count
    [SerializeField] int _count;
    public int Count { get => _count; private set { } }
}
