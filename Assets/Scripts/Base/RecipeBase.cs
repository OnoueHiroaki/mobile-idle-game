using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBase : MonoBehaviour
{
    [SerializeField] GameObject _gameObject;
    ItemBase _item;
    public virtual void Calculation(int materialScore1, int materialScore2)
    {
        _item.SetScore((materialScore1 + materialScore2) / 2);
    }
    //生成する時に行う
    void GetItem()
    {
        _item = _gameObject.GetComponent<ItemBase>();
    }
}
