using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionNode : NodeBase, INodeable
{
    //���̃m�[�h�ɐi�߂锻��
    [SerializeField] bool _nextPath;
    public bool NextPath { get => _nextPath; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}
