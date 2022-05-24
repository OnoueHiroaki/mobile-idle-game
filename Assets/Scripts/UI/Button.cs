using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
namespace UIExtension
{
    public class Button : MonoBehaviour
    {
        bool _isActive;
        [SerializeField] UnityEngine.UI.Button _button;
        Cultivation _cultivation;
        private void Start()
        {
            _cultivation = FindObjectOfType<Cultivation>();
        }
        public void SetActive()
        {
            _button.gameObject.SetActive(_isActive = _isActive == true ? false : true);
        }
        public void CloseButton()
        {
            _button.gameObject.SetActive(false);
        }
        public void Cultivation()
        {
            _cultivation.IdleCultivation();
        }
        public void TimeUpdate()
        {
                                                 //ä÷êîÇì¸ÇÍÇÈ
            _button.onClick.AsObservable().Subscribe();
        }
    }
}

