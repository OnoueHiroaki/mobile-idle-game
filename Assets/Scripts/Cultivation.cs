using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cultivation : MonoBehaviour
{
    static Cultivation s_instance;
    public static Cultivation Instance { get { return s_instance; } private set { } }
    //Í”|‚ªI‚í‚éŠÔ
    [SerializeField] int _time = 300;
    [SerializeField] int _createCount = 20;
    [SerializeField] GameObject _parent1, _parent2;
    MaterialBase _material1;
    MaterialBase _material2;
    private void Start()
    {
        s_instance = this;
        TimeSpan time = DateTime.Now - TimeManager.Instance.CropTime;
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
    void IdleCultivation()
    {
        TimeSpan time = DateTime.Now - TimeManager.Instance.CropTime;
        if (time.Minutes >= _time)
        {
            //c‚èŠÔ‚ğ‰ß‚¬‚Ä‚¢‚é‚½‚ßÅ‘åûŠn”‚Ìˆ—
            for (int i = 0; i < _createCount; i++)
            {
                CreateMaterial();
            }
        }
        else
        {
            //‰½•ªŒo‚Á‚Ä‚¢‚é‚©‚Æ‚»‚ê‚É‚æ‚Á‚ÄûŠn”‚ª•Ï‚í‚é
            for (int i = 0; i < time.Minutes; i += _time / _createCount)
            {
                //ˆê‚Â‚¾‚¯Í”|‚³‚¹‚éŠÖ”
                CreateMaterial();
            }
        }
    }
    void CreateMaterial()
    {
        var newObj1 = Instantiate(_material1);
        var newObj2 = Instantiate(_material2);
        newObj1.transform.SetParent(_parent1.transform, false);
        newObj2.transform.SetParent(_parent2.transform, false);
    }
    public void SetMaterial1(GameObject material)
    {
        _material1 = material.GetComponent<MaterialBase>();
    }
    public void SetMaterial2(GameObject material)
    {
        _material2 = material.GetComponent<MaterialBase>();
    }
}