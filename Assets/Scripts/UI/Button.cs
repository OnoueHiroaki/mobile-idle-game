using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UIExtension
{
    public class Button : MonoBehaviour
    {
        bool _isActive;
        [SerializeField] GameObject _gameObject;
        Cultivation _cultivation;
        private void Start()
        {
            _cultivation = FindObjectOfType<Cultivation>();
        }
        public void SetActive()
        {
            _gameObject.SetActive(_isActive = _isActive == true ? false : true);
        }
        public void CloseButton()
        {
            _gameObject.SetActive(false);
        }
        public void Cultivation()
        {
            _cultivation.IdleCultivation();
        }
    }
}

