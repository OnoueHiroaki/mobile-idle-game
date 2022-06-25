using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RecipeTree : IRecipeable
{
    [SerializeReference, SubclassSelector] SelectorNode _selector;

    public int Add(int num)
    {
        throw new System.NotImplementedException();
    }
}

//namespace BehaviorAI
//{
//    // BehaviorAIを使うUserに継承させる
//    public interface IBehavior
//    {
//        GameObject SetTarget();
//        void Call(IAction set);
//    }

//    // 別クラスで継承させて条件を決める 
//    public interface IConditional
//    {
//        GameObject Target { set; }
//        bool Check();
//    }

//    // 別クラスで継承させて行動を決める
//    public interface IAction
//    {
//        GameObject Target { set; }
//        void Execute();
//        bool End();
//        bool Reset { set; }
//    }


//    public class BehaviorTree : MonoBehaviour
//    {
//        enum State
//        {
//            Run,
//            Set,

//            None,
//        }

//        State _state = State.None;
//        [SerializeField] List<Selector> _selector = new List<Selector>();

//        [System.Serializable]
//        public class Selector
//        {
//            public List<Seqence> Datas = new List<Seqence>();

//            [System.Serializable]
//            public class Seqence
//            {
//                [SerializeReference, SubclassSelector]
//                public IConditional Conditional;
//                [SerializeReference, SubclassSelector]
//                public IAction Action;
//            }
//        }

//        SelectorNode _stN;
//        SequenceNode _sqN;

//        /// <summary>
//        /// 対象のObjectに対する行動を決める
//        /// </summary>
//        /// <typeparam name="T">自身のIBehavior</typeparam>
//        /// <param name="get">実行させる対象. this</param>
//        public void Repeater<T>(T get) where T : IBehavior
//        {
//            GameObject t = get.SetTarget();
//            switch (_state)
//            {
//                case State.Run:
//                    _sqN.Set(_selector[_stN.GetID].Datas[_sqN.SequenceID], get, ref _state, t);
//                    break;
//                case State.Set:
//                    _state = State.None;
//                    break;
//                case State.None:
//                    _stN = new SelectorNode();
//                    _sqN = new SequenceNode();
//                    _state = State.Set;
//                    _stN.Set(_selector, _sqN, ref _state, t);
//                    break;
//            }
//        }

//        class SelectorNode
//        {
//            // Note : 改善の余地あり. 現在は全て 0 を指定
//            public int GetID { get => _selectorID; }
//            int _selectorID = 0;

//            /// <summary>
//            /// どこのConditionalを調べるかを決める
//            /// </summary>
//            /// <param name="st">自身の持つSelecter</param>
//            /// <param name="sq">自身の持つSequence</param>
//            /// <param name="state">現在のState</param>
//            /// <param name="t">対象のObject</param>
//            public void Set(List<Selector> st, SequenceNode sq, ref State state, GameObject t)
//            {
//                ConditionalNode cN = new ConditionalNode();
//                cN.SetTarget = t;
//                if (st.Count <= 0)
//                {
//                    Debug.LogError("データがありません");
//                    return;
//                }
//                if (st.Count <= 1)
//                {
//                    _selectorID = 0;
//                    cN.Set(st[0], sq, ref state);
//                }
//                else
//                {
//                    // 乱数設定 : Note 改善の余地あり
//                    int randomID = Random.Range(0, st.Count);
//                    _selectorID = randomID;
//                    cN.Set(st[randomID], sq, ref state);
//                }
//            }
//        }

//        class ConditionalNode
//        {
//            public GameObject SetTarget { private get; set; }

//            /// <summary>
//            /// Conditinalを調べてTrueならそのConditionalを保存
//            /// </summary>
//            /// <param name="st">対象のSelector</param>
//            /// <param name="sq">Selectorに対するSequence</param>
//            /// <param name="state">現在のState</param>
//            public void Set(Selector st, SequenceNode sq, ref State state)
//            {
//                for (int id = 0; id < st.Datas.Count; id++)
//                {
//                    IConditional c = st.Datas[id].Conditional;
//                    c.Target = SetTarget;
//                    if (c.Check())
//                    {
//                        state = State.Run;
//                        sq.SequenceID = id;
//                        return;
//                    }
//                }

//                state = State.None;
//            }
//        }

//        class SequenceNode
//        {
//            public int SequenceID { get; set; } = 0;

//            /// <summary>
//            /// 保存したSequenceDataを走らせる
//            /// </summary>
//            /// <param name="sq">対象のSequenceData</param>
//            /// <param name="b">対象のIBehavior</param>
//            /// <param name="s">現在のState</param>
//            /// <param name="t">対象のObject</param>
//            public void Set(Selector.Seqence sq, IBehavior b, ref State s, GameObject t)
//            {
//                ActionNode aN = new ActionNode();
//                aN.SetTarget = t;
//                if (sq.Conditional.Check()) aN.Set(sq.Action, b, ref s);
//                else
//                {
//                    sq.Action.Reset = false;
//                    s = State.None;
//                }
//            }
//        }

//        class ActionNode
//        {
//            public GameObject SetTarget { get; set; }

//            /// <summary>
//            /// TrueだったConditionalに対するActionを対象に返す
//            /// </summary>
//            /// <param name="a">Conditionalに対するAction</param>
//            /// <param name="iB">対象のIBehavior</param>
//            /// <param name="state">現在のState</param>
//            public void Set(IAction a, IBehavior iB, ref State state)
//            {
//                a.Target = SetTarget;
//                if (a.End())
//                {
//                    state = State.None;
//                    a.Reset = false;
//                }
//                else
//                    iB.Call(a);
//            }
//        }
//    }
//}