using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraAspect : MonoBehaviour
{
    CanvasScaler _canvas;
    private void Start()
    {
        _canvas = GetComponent<CanvasScaler>();
        _canvas.referenceResolution = new Vector2(Screen.width, Screen.height);
    }
}
