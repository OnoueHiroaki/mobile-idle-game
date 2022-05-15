using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
    Person,

}
public class Node : MonoBehaviour
{
    //���V�s�ŌĂт܂Ƃ߂�
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

    public Node Person; // �e�m�[�h
    public Node Left; // �����̎q�m�[�h
    public Node Right; // �E���̎q�m�[�h
    public Node Up; // �㑤�̃m�[�h
    public Node Down; // �����̃m�[�h
    public int Level; // �K�w
    public int Threshold; // �������l
    public string Label; // ID
    public string Decision; // �ŏI����
    public bool NextPath; //���̃m�[�h�ɐi�߂锻��
}
