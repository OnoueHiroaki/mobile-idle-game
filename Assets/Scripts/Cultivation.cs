using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cultivation : MonoBehaviour
{
    //栽培が終わる時間(8時間)
    [SerializeField] int _time = 480;
    [SerializeField] int _cultivationTime;
    [SerializeField] GameObject _prefab;
    MaterialBase _material;
    void IdleCultivation()
    {
        TimeSpan time = DateTime.Now - TimeManager.Instance.CropTime;
        if (time.Minutes > _time)
        {
            //栽培が終わった時の処理
        }
        else
        {
            //何分経っているかとそれによって栽培される数が変わる
            for (int i = 0; i < time.Minutes; i += _cultivationTime)
            {
                //一つだけ栽培させる関数
            }
        }
    }
    void SetMaterial(GameObject material)
    {
        _material = material.GetComponent<MaterialBase>();
    }
}