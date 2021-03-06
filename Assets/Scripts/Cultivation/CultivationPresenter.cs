using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CultivationPresenter : MonoBehaviour
{
    static CultivationPresenter s_instance;
    public static CultivationPresenter Instance { get { return s_instance; } private set { } }
    //栽培が終わる時間
    [SerializeField] int _time = 300;
    [SerializeField] int _createCount = 20;
    [SerializeField] List<GameObject> _parentList = new List<GameObject>();
    //生成させる素材のID
    [SerializeField] List<int> _materialId;
    TimeSpan _timeDifference;
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
            //残り時間を過ぎているため最大収穫数の処理
            for (int i = 0; i < _createCount; i++)
            {
                CreateMaterial();
            }
        }
        else
        {
            //何分経っているかとそれによって収穫数が変わる
            for (int i = 0; i < time.Minutes; i += _time / _createCount)
            {
                //一つだけ栽培させる関数
                CreateMaterial();
            }
        }
        //収穫時間の更新
        tM.SetCropTime();
        tM.SetTimaSpan(time);
    }
    void CreateMaterial()
    {
        for (int i = 0; i < _parentList.Count; i++)
        {
            //var newObj = Instantiate(_materialList[i]);
            //newObj.transform.SetParent(_parentList[i].transform, false);
        }
    }
    public void SetMaterial1(GameObject material)
    {
        //_materialList[0] = material.GetComponent<MaterialBase>();
    }
    public void SetMaterial2(GameObject material)
    {
        //_materialList[1] = material.GetComponent<MaterialBase>();
    }
}