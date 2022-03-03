using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIExtension
{
    public class Button : MonoBehaviour
    {
        bool _isActive;
        [SerializeField] GameObject _gameObject;
        public void SetActive()
        {
            _gameObject.SetActive(_isActive = _isActive == true ? false : true);
        }
    }
}

