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
            //OnClickのイベント追加方法
            _action += Cultivation; 
            _button.onClick.AddListener(_action);
        }
        public void SetActive(GameObject gameobject)
        {
            //論理排他的 OR 演算子
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

