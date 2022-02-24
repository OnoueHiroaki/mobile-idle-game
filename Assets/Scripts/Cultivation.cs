using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cultivation : MonoBehaviour
{
    //Í”|‚ªI‚í‚éŽžŠÔ(8ŽžŠÔ)
    [SerializeField] int _time = 480;
    [SerializeField] int _cultivationTime;
    [SerializeField] GameObject _prefab;
    MaterialBase _material;
    void IdleCultivation()
    {
        TimeSpan time = DateTime.Now - TimeManager.Instance.CropTime;
        if (time.Minutes > _time)
        {
            //Í”|‚ªI‚í‚Á‚½Žž‚Ìˆ—
        }
        else
        {
            //‰½•ªŒo‚Á‚Ä‚¢‚é‚©‚Æ‚»‚ê‚É‚æ‚Á‚ÄÍ”|‚³‚ê‚é”‚ª•Ï‚í‚é
            for (int i = 0; i < time.Minutes; i += _cultivationTime)
            {
                //ˆê‚Â‚¾‚¯Í”|‚³‚¹‚éŠÖ”
            }
        }
    }
    void SetMaterial(GameObject material)
    {
        _material = material.GetComponent<MaterialBase>();
    }
}