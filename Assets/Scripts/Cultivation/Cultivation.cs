using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Cultivation : MonoBehaviour
{
    static Cultivation s_instance;
    public static Cultivation Instance { get { return s_instance; } private set { } }
    [SerializeField] MaterialData _material;
    [SerializeField] GameObject _parent;
    [SerializeField] int _id;
    public void CreateTest(bool debugMode,int createCount)
    {
        if (debugMode == true)
        {
            for (int i = 0; i < createCount; i++)
            {
                CreateMaterial();
            }
        }
    }
    public void IdleCultivation(int time,TimeSpan interval,int createCount)
    {
        TimeManager tm = TimeManager.Instance;
        interval = DateTime.Now - tm.CropTime;
        if (interval.Minutes >= time)
        {
            //�c�莞�Ԃ��߂��Ă��邽�ߍő���n���̏���
            for (int i = 0; i < createCount; i++)
            {
                CreateMaterial();
            }
        }
        else
        {
            //�����o���Ă��邩�Ƃ���ɂ���Ď��n�����ς��
            for (int i = 0; i < interval.Minutes; i += time / createCount)
            {
                //������͔|������֐�
                CreateMaterial();
            }
        }
        //���n���Ԃ̍X�V
        tm.SetCropTime();
        tm.SetTimaSpan(interval);
    }
    void CreateMaterial()
    {
        var newMaterial = _material.GetData(_id);
        var newObj = Instantiate(newMaterial.Object);
        newObj.GetComponent<MaterialInfo>().SetUp(newMaterial);
        newObj.transform.SetParent(_parent.transform, false);
    }
    public void SetID(Material material)
    {
        _id = material.ID;
    }
}
