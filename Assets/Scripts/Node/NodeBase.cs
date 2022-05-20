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
public class NodeBase : INodeable
{
    // ŠK‘w
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    //Count
    [SerializeField] int _count;
    public int Count { get => _count; private set { } }
    [SerializeReference, SubclassSelector] NodeBase _node;
    public NodeBase Node { get => _node; private set { _node = value; } }

    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}
