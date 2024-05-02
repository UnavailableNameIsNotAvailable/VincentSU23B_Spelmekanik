using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraverserMovement : MonoBehaviour
{
    public List<GameObject> wayPoints;

    int currentWayPoint = 0;

    public float Speed = 100;
    // Waypoints finns i en lista. Indexen i skriptet �r en int variabel som �ndras. Speed float �ndrar hastigheten.
    void Start()
    {
        
    }

    // Spelaren r�r sig mot den designerade waypointen. N�r den n�r fram s� f�r den en ny random waypoint.
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Speed * Time.deltaTime);

        if (Vector2.Distance(this.transform.position, wayPoints[currentWayPoint].transform.position) == 0)
            currentWayPoint = Random.Range(0, 9);
    }
}
