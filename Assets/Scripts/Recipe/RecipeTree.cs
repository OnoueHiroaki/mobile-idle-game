using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRecipeable
{
    int Add(int num);
}
public interface IConditionable
{
    void Condition();
}
public interface IActionable
{
    void Action();
}
public class RecipeTree : IRecipeable
{
    [SerializeReference, SubclassSelector] SelectorNode _selector;

    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}

public class NodeBase : IRecipeable
{
    //�m�[�h
    //[SerializeReference, SubclassSelector] NodeBase _node;
    //public NodeBase Node { get => _node; private set { } }
    //// �K�w
    //[SerializeField] int _level;
    //public int Level { get => _level; private set { } }

    //���̃m�[�h�ɐi�߂锻��
    [SerializeField] bool _nextPath;
    public bool NextPath
    {
        get
        {
            return _nextPath;
        }
        private set
        {
            NextPath = value;
            if (NextPath)
            {
                //true�ɂȂ������ɍs�Ȃ�����
                Debug.Log("���̃m�[�h�ɍs���܂�");
            }
            else
            {
                Debug.Log("�����������Ă��܂���");
            }
        }
    }
    //Type
    [SerializeField] MaterialType _type;
    public MaterialType Type { get => _type; private set { } }
    // ID
    [SerializeField] int _label;
    public int Label { get => _label; private set { } }
    //Count
    [SerializeField] int _count;
    public int Count { get => _count; private set { } }

    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}
public class ActionNode : NodeBase, IActionable
{
    public void Action()
    {
        Debug.Log("�A�N�V�����m�[�h");
    }
}
public class ConditionNode : NodeBase
{

}
public class RepeaterNode : NodeBase
{

}
public class SequenceNode : NodeBase
{

}
public class SelectorNode : NodeBase
{
    [SerializeReference, SubclassSelector] ActionNode _action;
    public ActionNode Action { get => _action; set { } }
}