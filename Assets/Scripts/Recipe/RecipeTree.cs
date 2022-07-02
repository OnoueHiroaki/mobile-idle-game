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
    //ノード
    //[SerializeReference, SubclassSelector] NodeBase _node;
    //public NodeBase Node { get => _node; private set { } }
    //// 階層
    //[SerializeField] int _level;
    //public int Level { get => _level; private set { } }

    //次のノードに進める判定
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
                //trueになった時に行なう処理
                Debug.Log("次のノードに行きます");
            }
            else
            {
                Debug.Log("条件が合っていません");
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
        Debug.Log("アクションノード");
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