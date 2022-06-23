using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionRecipe : RecipeBase
{
    [SerializeField] GameObject _item;
    //レシピに必要なID
    [SerializeField] List<int> _data;
    GreenGrass _greenGrass;
    RedGrass _redGrass;
    //調合させる(調合ボタンで使用する)
    public void Formulation()
    {
        
    }
    public override void Recipe()
    {
        if (_data[0] == 1)
        {

        }
    }
}
