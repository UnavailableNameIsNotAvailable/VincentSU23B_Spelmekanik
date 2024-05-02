using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraverserSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Traverser;
    
    void Start()
    {
        for (int i = 0; i < 175; i++)
        {
            Instantiate(Traverser);
        }
    }

    // Scriptet spawnar in 175 Traversers vid start.
    void Update()
    {
        
    }
}
