using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NodeBase 
{
    // ŠK‘w
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    //Ÿ‚Ìƒm[ƒh‚Éi‚ß‚é”»’è
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //Count
    [SerializeField] int _count;
    public int Count { get => _count; private set { } }
}
