using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum RecipeType
{
    Potion,
}
[CreateAssetMenu(fileName = "RecipeData")]
public class RecipeData : ScriptableObject
{
    [SerializeField] List<Recipe> _recipe;
    public List<Recipe> Recipes { get => _recipe; set { } }
    public Recipe GetRecipe(int num) => _recipe[num];
}

[System.Serializable]
public class Recipe
{
    [SerializeField] List<int> _setData;
    [SerializeField] GameObject _gameObject;
    public List<int> SetData { get => _setData; set { } }
}
