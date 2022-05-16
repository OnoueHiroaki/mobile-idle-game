using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialBase : MonoBehaviour
{
    [SerializeField] int _score;
    public int Score { get => _score; protected set { } }
}
public enum GrassType
{
    GreenGrass,
    RedGrass,
}
public enum OreType
{

}


