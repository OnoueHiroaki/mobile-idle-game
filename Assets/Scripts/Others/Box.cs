using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public static Box Instance { get; private set; }
    [SerializeField] Transform _harvestArea1, _harvestArea2;
    
    private void Awake()
    {
        Instance = this;
    }
    
    public void GetMaterial()
    {
        var child1 = _harvestArea1;
        var child2 = _harvestArea2;
        for (int i = 0; i < child1.childCount; i++)
        {
            //_materials.Add(child1.GetChild(i).gameObject.GetComponent<MaterialBase>());
            Destroy(child1.GetChild(i).gameObject);
        }
        for (int i = 0; i < child2.childCount; i++)
        {
            //_materials.Add(child2.GetChild(i).gameObject.GetComponent<MaterialBase>());
            Destroy(child2.GetChild(i).gameObject);
        }
    }
}
