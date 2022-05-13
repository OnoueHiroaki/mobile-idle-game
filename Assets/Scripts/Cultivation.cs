using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cultivation : MonoBehaviour
{
    static Cultivation s_instance;
    public static Cultivation Instance { get { return s_instance; } private set { } }
    //�͔|���I��鎞��
    [SerializeField] int _time = 300;
    [SerializeField] int _createCount = 20;
    [SerializeField] List<GameObject> _parentList = new List<GameObject>();
    TimeSpan _timeDifference;
    List<MaterialBase> _materialList = new List<MaterialBase>();
    private void Start()
    {
        s_instance = this;
        //IdleCultivation();
        //CreateTest();
    }
    public void CreateTest()
    {
        for (int i = 0; i < _createCount; i++)
        {
            CreateMaterial();
        }
    }
    public void IdleCultivation()
    {
        TimeManager tM = TimeManager.Instance; 
        TimeSpan time = DateTime.Now - tM.CropTime;
        if (time.Minutes >= _time)
        {
            //�c�莞�Ԃ��߂��Ă��邽�ߍő���n���̏���
            for (int i = 0; i < _createCount; i++)
            {
                CreateMaterial();
            }
        }
        else
        {
            //�����o���Ă��邩�Ƃ���ɂ���Ď��n�����ς��
            for (int i = 0; i < time.Minutes; i += _time / _createCount)
            {
                //������͔|������֐�
                CreateMaterial();
            }
        }
        //���n���Ԃ̍X�V
        tM.SetCropTime();
        tM.SetTimaSpan(time);
    }
    void CreateMaterial()
    {
        for (int i = 0; i < _parentList.Count; i++)
        {
            var newObj = Instantiate(_materialList[i]);
            newObj.transform.SetParent(_parentList[i].transform, false);
        }
    }
    public void SetMaterial1(GameObject material)
    {
        _materialList[0] = material.GetComponent<MaterialBase>();
    }
    public void SetMaterial2(GameObject material)
    {
        _materialList[1] = material.GetComponent<MaterialBase>();
    }
}