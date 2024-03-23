using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainmove : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints for the train to follow
    public float speed = 6f; // Speed of the train
    private int currentWaypointIndex = 0;
    private bool isMoving = true;
    private int flag = 0;
    // Start is called before the first frame update
    void Start()
    {
       // transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);
    }

    public void SkipWaypoints()
    {
        currentWaypointIndex = 6;
        flag = 1;

    }
    // Update is called once per frame
    void Update()
    {

        
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position,
                speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.01f)
            {
                // Move to the next waypoint
                if (currentWaypointIndex != waypoints.Length || flag != 0)
                    currentWaypointIndex++;
            }

            if (currentWaypointIndex < waypoints.Length)
            {
                Vector3 direction = waypoints[currentWaypointIndex].position - transform.position;
                if (direction != Vector3.zero)
                {
                    Quaternion rotation = Quaternion.LookRotation(direction);
                    transform.rotation =
                        Quaternion.Slerp(transform.rotation, rotation,
                            Time.deltaTime * 5f);
                }
            }
        }
    
}
