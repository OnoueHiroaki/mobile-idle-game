using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
    Person,
}
public class NodeBase : MonoBehaviour
{
    //���V�s�ŌĂт܂Ƃ߂�
    public NodeBase(NodeBase person, int level, int threshold, string label, string decision, bool nextPath)
    {
        Person = person;
        Level = level;
        Threshold = threshold;
        Label = label;
        Decision = decision;
        NextPath = nextPath;
    }

    public NodeBase Person; // �e�m�[�h
    public NodeBase Child; // �q�m�[�h
    public int Level; // �K�w
    public int Threshold; // �������l
    public string Label; // ID
    public string Decision; // �ŏI����
    public bool NextPath; //���̃m�[�h�ɐi�߂锻��
}
