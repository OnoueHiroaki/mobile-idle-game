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
    // ŠK‘w
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    // ‚µ‚«‚¢’l
    [SerializeField] int _threshold;
    public int Threshold { get => _threshold; private set { } }
    //ŽŸ‚Ìƒm[ƒh‚Éi‚ß‚é”»’è
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //enum‚ÌŽí—Þ
    Enum[] types = new Enum[3];
    Dictionary<Enum, Dictionary<int, int>> Items = new Dictionary<Enum, Dictionary<int, int>>();
}
