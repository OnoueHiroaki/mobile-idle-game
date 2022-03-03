using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public static Box Instance { get; private set; }
    [SerializeField] Transform _harvestArea1, _harvestArea2;
    List<MaterialBase> _materials;
    public List<MaterialBase> Materials { get => _materials; set { } }
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {

    }
    public void GetMaterial()
    {
        var child1 = _harvestArea1;
        var child2 = _harvestArea2;
        for (int i = 0; i < child1.GetChildCount(); i++)
        {
            _materials.Add(child1.GetChild(i).gameObject.GetComponent<MaterialBase>());
            Destroy(child2.GetChild(i).gameObject);
        }
        for (int i = 0; i < child2.GetChildCount(); i++)
        {
            _materials.Add(child2.GetChild(i).gameObject.GetComponent<MaterialBase>());
            Destroy(child2.GetChild(i).gameObject);
        }
    }
}
