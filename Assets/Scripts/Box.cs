using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public static Box Instance { get; private set; }
    [SerializeField] GameObject _harvestArea1, _harvestArea2;
    List<MaterialBase> _materials;
    public List<MaterialBase> Materials { get => _materials; set { } }
    private void Awake()
    {
        Instance = this;
    }
}
