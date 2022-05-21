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
    //�e�m�[�h
    [SerializeField, SubclassSelector] NodeBase _personNode;
    public NodeBase PersonNode { get => _personNode; private set { } }
    // �K�w
    [SerializeField] int _level;
    public int Level { get => _level; private set { } }
    //���̃m�[�h�ɐi�߂锻��
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //Count
    [SerializeField] int _count;
    public int Count { get => _count; private set { } }
    // �m�[�h�̏��
    [SerializeField] NodeState _state;
    public NodeState State { get => _state; private set { } }
    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}
