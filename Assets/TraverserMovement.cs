using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraverserMovement : MonoBehaviour
{
    public List<GameObject> wayPoints;

    int currentWayPoint = 0;

    public float Speed = 100;
    // Waypoints finns i en lista. Indexen i skriptet är en int variabel som ändras. Speed float ändrar hastigheten.
    void Start()
    {
        
    }

    // Spelaren rör sig mot den designerade waypointen. När den når fram så får den en ny random waypoint.
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Speed * Time.deltaTime);

        if (Vector2.Distance(this.transform.position, wayPoints[currentWayPoint].transform.position) == 0)
            currentWayPoint = Random.Range(0, 9);
    }
}
