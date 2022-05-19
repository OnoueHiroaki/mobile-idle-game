using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : UnityEngine.MonoBehaviour
{
    List<GameObject> _materialObjectList;
    GameObject _poolPrefab;
    //‚±‚±‚©‚ç‰º‚ÍŽg‚¦‚È‚¢
    public void CreateMaterialPool(GameObject materialPrefab, int maxCount)
    {
        _poolPrefab = materialPrefab;
        _materialObjectList = new List<GameObject>();
        for (int i = 0; i < maxCount; i++)
        {
            var newObject = CreateNewObj();
            newObject.SetActive(false);
            _materialObjectList.Add(newObject);
        }
    }
    public GameObject GetGameObject()
    {
        foreach (var item in _materialObjectList)
        {
            if (item.activeSelf == false)
            {
                item.SetActive(false);
                return item;
            }
        }
        var newObj = CreateNewObj();
        newObj.SetActive(true);
        _materialObjectList.Add(newObj);
        return newObj;
    }
    GameObject CreateNewObj()
    {
        var newObj = Instantiate(_poolPrefab);
        newObj.name = _poolPrefab.name + (_materialObjectList.Count + 1);
        return newObj;
    }
}
