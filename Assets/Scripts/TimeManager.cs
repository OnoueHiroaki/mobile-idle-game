using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : MonoBehaviour
{
    //Œ»Ý‚ÌŽž
    //DateTime _currentTime;
    static TimeManager s_instance = new TimeManager();
    public static TimeManager Instance { get => s_instance; private set { } }
    //ŽûŠn‚µ‚½Žž
    DateTime _cropTime;
    public DateTime CropTime { get => _cropTime; private set { } }
    private TimeSpan _timeSpan;
    public TimeSpan TimeSpan { get => _timeSpan; private set { } }
    private void Awake()
    {
        s_instance = this;
    }
    public void GetTimeSpan()
    {
        _timeSpan = DateTime.Now - _cropTime;
    }
    public void SetCropTime()
    {
        _cropTime = DateTime.Now;
    }
}
