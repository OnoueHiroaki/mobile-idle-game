using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cultivation : MonoBehaviour
{
    //�͔|���I��鎞��(8����)
    [SerializeField] int _time = 480;
    [SerializeField] int _cultivationTime;
    [SerializeField] GameObject _prefab;
    MaterialBase _material;
    void IdleCultivation()
    {
        TimeSpan time = DateTime.Now - TimeManager.Instance.CropTime;
        if (time.Minutes > _time)
        {
            //�͔|���I��������̏���
        }
        else
        {
            //�����o���Ă��邩�Ƃ���ɂ���č͔|����鐔���ς��
            for (int i = 0; i < time.Minutes; i += _cultivationTime)
            {
                //������͔|������֐�
            }
        }
    }
    void SetMaterial(GameObject material)
    {
        _material = material.GetComponent<MaterialBase>();
    }
}