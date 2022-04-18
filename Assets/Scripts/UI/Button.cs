using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UIExtension
{
    public class Button : MonoBehaviour
    {
        bool _isActive;
        [SerializeField] List<GameObject> _gameObjects = new List<GameObject>();
        Cultivation _cultivation;
        private void Start()
        {
            _cultivation = FindObjectOfType<Cultivation>();
        }
        public void SetActive()
        {
            for (int i = 0; i < _gameObjects.Count; i++)
            {
                _gameObjects[i].SetActive(_isActive = _isActive == true ? false : true);
            }
        }
        public void CloseButton()
        {
            for (int i = 0; i < _gameObjects.Count; i++)
            {
                _gameObjects[i].SetActive(false);
            }
        }
        public void Cultivation()
        {
            _cultivation.IdleCultivation();
        }
    }
}

