using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicerMovement : MonoBehaviour
{
    public int Speed;
    void Start()
    {
        
    }

    // Slicern faller i en best�md fart. N�r den n�r en gr�ns s� flyttas den upp i Y v�rdet. X v�rdet �ndras slumpm�ssigt.
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
