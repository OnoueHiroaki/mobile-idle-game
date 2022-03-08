using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : MonoBehaviour
{
    //���݂̎���
    //DateTime _currentTime;
    static TimeManager s_instance = new TimeManager();
    public static TimeManager Instance { get => s_instance; private set { } }
    //���n��������
    public DateTime CropTime { get; private set; }
    private void Awake()
    {
        s_instance = this;
    }
    public void CropResetTime()
    {
        CropTime = DateTime.Now;
    }
}
