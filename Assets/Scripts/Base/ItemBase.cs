using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    int _score;
    public void SetScore(int materialScore)
    {
        _score = materialScore;
    }
    //お金にする時の計算はレア度を決めてそのレア度の数値をかける

}
