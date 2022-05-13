using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RecipeData")]
public class RecipeData : ScriptableObject
{
    [SerializeField] List<Recipe> _recipe;
    public Recipe GetRecipe(int num) => _recipe[num];
}
public enum RecipeType
{
    Potion,

}
[System.Serializable]
public class Recipe
{
    [SerializeField] RecipeType _recipeID;
    public RecipeType RecipeID { get; private set; }
    [SerializeField] List<MaterialType> _materialID;
    public List<MaterialType> MaterialID { get; private set; }
}
