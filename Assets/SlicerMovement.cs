using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicerMovement : MonoBehaviour
{
    public int Speed;
    void Start()
    {
        
    }

    // Slicern faller i en bestämd fart. När den når en gräns så flyttas den upp i Y värdet. X värdet ändras slumpmässigt.
    void Update()
    {
        if(transform.position.y > -58)
        {
            transform.position += new Vector3(0, Speed * -1, 0) * Time.deltaTime;
        }
        else
        {
            transform.position = new Vector3(Random.Range(-130, 100), 100, 0);
        }
    }
}
