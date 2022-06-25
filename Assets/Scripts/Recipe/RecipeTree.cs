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
//    // BehaviorAI���g��User�Ɍp��������
//    public interface IBehavior
//    {
//        GameObject SetTarget();
//        void Call(IAction set);
//    }

//    // �ʃN���X�Ōp�������ď��������߂� 
//    public interface IConditional
//    {
//        GameObject Target { set; }
//        bool Check();
//    }

//    // �ʃN���X�Ōp�������čs�������߂�
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
//        /// �Ώۂ�Object�ɑ΂���s�������߂�
//        /// </summary>
//        /// <typeparam name="T">���g��IBehavior</typeparam>
//        /// <param name="get">���s������Ώ�. this</param>
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
//            // Note : ���P�̗]�n����. ���݂͑S�� 0 ���w��
//            public int GetID { get => _selectorID; }
//            int _selectorID = 0;

//            /// <summary>
//            /// �ǂ���Conditional�𒲂ׂ邩�����߂�
//            /// </summary>
//            /// <param name="st">���g�̎���Selecter</param>
//            /// <param name="sq">���g�̎���Sequence</param>
//            /// <param name="state">���݂�State</param>
//            /// <param name="t">�Ώۂ�Object</param>
//            public void Set(List<Selector> st, SequenceNode sq, ref State state, GameObject t)
//            {
//                ConditionalNode cN = new ConditionalNode();
//                cN.SetTarget = t;
//                if (st.Count <= 0)
//                {
//                    Debug.LogError("�f�[�^������܂���");
//                    return;
//                }
//                if (st.Count <= 1)
//                {
//                    _selectorID = 0;
//                    cN.Set(st[0], sq, ref state);
//                }
//                else
//                {
//                    // �����ݒ� : Note ���P�̗]�n����
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
//            /// Conditinal�𒲂ׂ�True�Ȃ炻��Conditional��ۑ�
//            /// </summary>
//            /// <param name="st">�Ώۂ�Selector</param>
//            /// <param name="sq">Selector�ɑ΂���Sequence</param>
//            /// <param name="state">���݂�State</param>
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
//            /// �ۑ�����SequenceData�𑖂点��
//            /// </summary>
//            /// <param name="sq">�Ώۂ�SequenceData</param>
//            /// <param name="b">�Ώۂ�IBehavior</param>
//            /// <param name="s">���݂�State</param>
//            /// <param name="t">�Ώۂ�Object</param>
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
//            /// True������Conditional�ɑ΂���Action��ΏۂɕԂ�
//            /// </summary>
//            /// <param name="a">Conditional�ɑ΂���Action</param>
//            /// <param name="iB">�Ώۂ�IBehavior</param>
//            /// <param name="state">���݂�State</param>
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