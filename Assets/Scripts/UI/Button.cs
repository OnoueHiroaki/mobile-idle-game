using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
namespace UIExtension
{
    public class Button : MonoBehaviour
    {
        bool _isActive;
        [SerializeField] GameObject _gameObject;
        [SerializeField] UnityEngine.UI.Button _button;
        Cultivation _cultivation;
        private void Start()
        {
            _cultivation = FindObjectOfType<Cultivation>();
            _button.OnClickAsObservable().Subscribe(_ => Cultivation());
        }
        public void SetActive()
        {
            //ò_óùîrëºìI OR ââéZéq
            _gameObject.SetActive(_isActive ^= true);
        }
        public void CloseButton()
        {
            _button.gameObject.SetActive(false);
        }
        public void Cultivation()
        {
            _cultivation.IdleCultivation();
        }
    }
}

