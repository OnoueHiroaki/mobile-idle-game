using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : MonoBehaviour
{
    //���݂̎���
    //DateTime _currentTime;
    public static TimeManager Instance { get; private set; }
    //���n��������
    public DateTime CropTime { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    public void CropResetTime()
    {
        CropTime = DateTime.Now;
    }
}
