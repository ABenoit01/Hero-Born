using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform GetWaypoint(int waypointIndex)
    {
        return transform.GetChild(waypointIndex);
    }

    public int GetNextWaypointIndex(int currentWaypointindex)
    {
        int nextWaypointIndex = currentWaypointindex++;

        if (nextWaypointIndex == transform.childCount)
        {
            nextWaypointIndex = 0;
        }
        return nextWaypointIndex;    
    }


}
