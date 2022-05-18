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
    [SerializeField] List<RecipeType> _type;
    [SerializeField] List<Recipe> _recipe;
    public RecipeType GetType(int num) => _type[num];
    public Recipe GetRecipe(int num) => _recipe[num];
}

[System.Serializable]
public class Recipe
{
    [SerializeField] NodePerson _person;
    [SerializeField] List<NodeChild> _child;
}
