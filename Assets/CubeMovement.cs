using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    //Hastighet
    public float DashSpeed;
    public float Speed;

    Rigidbody2D PlayerRb;
    //Används senare för dash direction
    int PlayerDirectionX;
    int PlayerDirectionY;
    
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    //Movement script där Dash direction ändras med Spelar direction. X och Y.
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, Speed, 0) * Time.deltaTime;
            PlayerDirectionY = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, (Speed * -1), 0) * Time.deltaTime;
            PlayerDirectionY = -1;
        }
        else
        {
            PlayerDirectionY = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3((Speed * -1), 0, 0) * Time.deltaTime;
            PlayerDirectionX = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
            PlayerDirectionX = 1;
        }
        else
        {
            PlayerDirectionX = 0;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRb.AddForce(new Vector2(PlayerDirectionX * DashSpeed, PlayerDirectionY * DashSpeed), ForceMode2D.Impulse);
            GetComponent<BoxCollider2D>().enabled = false;
            Invoke("enableColliders", 1);
        }
           // Dashspeed gånger X och Y värden av spelarens riktning som är antingen: 1, -1 eller 0.
    }      // Collision försvinner under en dash för att kunna dasha genom hinder.
    void enableColliders()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
