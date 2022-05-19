using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager : UnityEngine.MonoBehaviour
{
    static TimeManager s_instance = new TimeManager();
    public static TimeManager Instance { get => s_instance; private set { } }
    //���n��������
    DateTime _cropTime;
    public DateTime CropTime { get => _cropTime; private set { } }
    private TimeSpan _timeSpan;
    private void Awake()
    {
        s_instance = this;
    }
    //�͔|���Ԃ�����n���Ԃ܂ł̎��Ԃ�ۑ�����
    public void SetTimaSpan(TimeSpan time)
    {
        _timeSpan = time + _timeSpan;
    }
    //���n���Ԃ̍X�V
    public void SetCropTime()
    {
        _cropTime = DateTime.Now;
    }
}
