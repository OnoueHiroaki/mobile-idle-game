using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
    Person,

}
public class Node : MonoBehaviour
{
    //レシピで呼びまとめる
    public Node(Node person, Node left, Node right, Node up, Node down, int level, int threshold, string label, string decision,bool nextPath)
    {
        Person = person;
        Left = left;
        Right = right;
        Up = up;
        Down = down;
        Level = level;
        Threshold = threshold;
        Label = label;
        Decision = decision;
        NextPath = nextPath;
    }

    public Node Person; // 親ノード
    public Node Left; // 左側の子ノード
    public Node Right; // 右側の子ノード
    public Node Up; // 上側のノード
    public Node Down; // 下側のノード
    public int Level; // 階層
    public int Threshold; // しきい値
    public string Label; // ID
    public string Decision; // 最終結果
    public bool NextPath; //次のノードに進める判定
}
