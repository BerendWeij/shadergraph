using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeToMaterial : MonoBehaviour
{
    [SerializeField] private string propertyName;
    
    [SerializeField] private Material targetMaterial;

    void Update()
    {
        if (targetMaterial == null)
        {
            return;
        }
        
        targetMaterial.SetFloat(propertyName, Random.Range(0f, 2f));
    }
}
