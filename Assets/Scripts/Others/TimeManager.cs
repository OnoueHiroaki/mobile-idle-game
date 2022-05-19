using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : UnityEngine.MonoBehaviour
{
    static TimeManager s_instance = new TimeManager();
    public static TimeManager Instance { get => s_instance; private set { } }
    //ûŠn‚µ‚½
    DateTime _cropTime;
    public DateTime CropTime { get => _cropTime; private set { } }
    private TimeSpan _timeSpan;
    private void Awake()
    {
        s_instance = this;
    }
    //Í”|ŠÔ‚©‚çûŠnŠÔ‚Ü‚Å‚ÌŠÔ‚ğ•Û‘¶‚·‚é
    public void SetTimaSpan(TimeSpan time)
    {
        _timeSpan = time + _timeSpan;
    }
    //ûŠnŠÔ‚ÌXV
    public void SetCropTime()
    {
        _cropTime = DateTime.Now;
    }
}
