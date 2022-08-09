using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelInfo : MonoBehaviour
{
    [SerializeField] Image _image;
    [SerializeField] Button _selectButton;
    [SerializeField] Text _nameText;
    [SerializeField] Text _typeText;
    [SerializeField] Text _scoreText;
    MaterialInfo _material;
    /// <summary>
    /// 素材ボタンを押した時に処理を行なう
    /// </summary>
    public void SetData()
    {
        _image.sprite = _material.Data.Sprite;
        _nameText.text = _material.Data.Name;
        _typeText.text = "タイプ:" + _material.Data.Type.ToString();
        _scoreText.text = "スコア:" + _material.Score.ToString();
    }
    public void GetMaterial(MaterialInfo materialInfo)
    {
        _material = materialInfo;
    }
}
