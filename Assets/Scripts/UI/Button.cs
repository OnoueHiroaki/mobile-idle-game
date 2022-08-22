using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
namespace UIExtension
{
    public class Button : MonoBehaviour
    {
        bool _isActive;
        UnityEngine.UI.Button _button;
        Cultivation _cultivation;
        UnityEngine.Events.UnityAction _action;
        private void Start()
        {
            _button = GetComponent<UnityEngine.UI.Button>();
            _cultivation = FindObjectOfType<Cultivation>();
            _button.OnClickAsObservable().Subscribe(_ => Cultivation());
            //OnClick�̃C�x���g�ǉ����@
            _action += Cultivation; 
            _button.onClick.AddListener(_action);
        }
        public void SetActive(GameObject gameobject)
        {
            //�_���r���I OR ���Z�q
            gameobject.SetActive(_isActive ^= true);
        }
        public void CloseButton(GameObject gameobject)
        {
            gameobject.gameObject.SetActive(false);
        }
        void Cultivation()
        {
            //_cultivation.IdleCultivation();
        }
    }
}

