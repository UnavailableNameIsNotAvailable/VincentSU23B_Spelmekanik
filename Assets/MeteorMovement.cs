using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//Meteoren r�r sig f�r alltid h�gerut.
    {
        transform.position += new Vector3(20, 0, 0) * Time.deltaTime;

    }
}
