using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionRecipe : RecipeBase
{
    GrassType _grassType = GrassType.CommonGrass;
    StoneType _stoneType = StoneType.CommonStone;
    public override void Formulation()
    {        
        if (_grassType == GrassType.CommonGrass)
        {
            if (_stoneType == StoneType.CommonStone)
            {

            }
        }
    }
}
