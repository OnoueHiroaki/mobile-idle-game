using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
    Person,
}
public class NodeBase : MonoBehaviour
{
    //レシピで呼びまとめる
    public NodeBase(NodeBase person, int level, int threshold, string label, string decision, bool nextPath)
    {
        Person = person;
        Level = level;
        Threshold = threshold;
        Label = label;
        Decision = decision;
        NextPath = nextPath;
    }

    public NodeBase Person; // 親ノード
    public NodeBase Child; // 子ノード
    public int Level; // 階層
    public int Threshold; // しきい値
    public string Label; // ID
    public string Decision; // 最終結果
    public bool NextPath; //次のノードに進める判定
}
