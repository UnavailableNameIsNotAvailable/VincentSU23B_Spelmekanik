using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMotion : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    Vector3 Velocity;
    void Start()
    {
        
    }

    // En smooth delay för backgrunden att följa spelaren.
    void Update()
    {
        Vector2 targetposition = player.transform.position + new Vector3(0, 0, 0);
        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref Velocity, 0.9f);
    }
}
