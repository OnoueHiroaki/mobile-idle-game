using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeState
{
    Inactive,
    Success,
    Failure,
    Running,
    Completed
}
public class NodeBase : IRecipeable
{
    //親ノード
    [SerializeField, SubclassSelector] NodeBase _personNode;
    public NodeBase PersonNode { get => _personNode; private set { } }
    // 階層
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    //次のノードに進める判定
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //Count
    [SerializeField] int _count;
    public int Count { get => _count; private set { } }
    // ノードの状態
    [SerializeField] NodeState _state;
    public NodeState State { get => _state; private set { } }
    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}
