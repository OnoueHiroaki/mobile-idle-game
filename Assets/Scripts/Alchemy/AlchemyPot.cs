using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyPot : MonoBehaviour
{
    [SerializeField] RecipeData _recipeData;
    [SerializeField] List<int> _getData;

    
    void Get()
    {

    }
    bool Recipe()
    {
        for (int i = 0; i < _recipeData.Recipes.Count; i++)
        {
            int checkCount = 0;
            for (int j = 0; j < _recipeData.GetRecipe(i).SetData.Count; j++)
            {
                for (int n = 0; n < _getData.Count; n++)
                {
                    if (_recipeData.GetRecipe(i).SetData[j] == _getData[n])
                    {
                        Debug.Log(_recipeData.GetRecipe(i).SetData[j] + " " + _getData[n] + "一致した");
                        checkCount++;
                        break;
                    }
                    Debug.Log(_recipeData.GetRecipe(i).SetData[j] + " " + _getData[n] + "一致しない");
                }
                Debug.Log(j + "抜けました");
            }
            if (checkCount >= _recipeData.GetRecipe(i).SetData.Count)
            {
                return true;
            }
        }
        return false;
    }
}
