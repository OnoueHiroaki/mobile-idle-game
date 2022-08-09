using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UIExtension
{
    public class Image : MonoBehaviour
    {
        [SerializeField] UnityEngine.UI.Image _image;
        public void SetImage(MaterialInfo material)
        {
            _image.sprite = material.Data.Sprite;
        }
    }
}
