using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : MonoBehaviour
{
    static TimeManager s_instance = new TimeManager();
    public static TimeManager Instance { get => s_instance; private set { } }
    //収穫した時刻
    DateTime _cropTime;
    public DateTime CropTime { get => _cropTime; private set { } }
    private TimeSpan _timeSpan;
    void Awake()
    {
        s_instance = this;
    }
    //栽培時間から収穫時間までの時間を保存する
    public void SetTimaSpan(TimeSpan time)
    {
        _timeSpan = time + _timeSpan;
    }
    //収穫時間の更新
    public void SetCropTime()
    {
        _cropTime = DateTime.Now;
    }
}
