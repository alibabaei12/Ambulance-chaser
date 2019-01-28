using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer line;
    private Vector2 mousePosition;

    public GameObject ali;
    private PlayerMobility player;
    [SerializeField] private Vector3[] waypoints;
 
    public int waypointIndex;
    [SerializeField] private bool simplifyLine = false;
    [SerializeField] private float simplifyTolerance = 0.02f;

    public float speed;

    private void Start()
    {
        waypoints = new Vector3[100];
        player = ali.GetComponent<PlayerMobility>();
        line = GetComponent<LineRenderer>();
        //line.SetPosition(0, mousePosition);
        //line.enabled = true;

    }
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) //Or use GetKey with key defined with mouse button
        {
            // transform.position = waypoints[]
           
            //reset
            waypoints = new Vector3[100];
            line.positionCount = 0;
            //line.SetPosition(line.positionCount - 1, mousePosition);
        }

        if (Input.GetMouseButton(0)) //Or use GetKey with key defined with mouse button
        {
            
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            line.positionCount++;
            //test = line.positionCount;
            //line.GetPosition(test);

            waypoints[line.positionCount] = mousePosition; 

            line.SetPosition(line.positionCount - 1, mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (waypointIndex <= waypoints.Length - 1)
            {


                // Move Enemy from current waypoint to the next one
                // using MoveTowards method
                player.position = Vector3.MoveTowards(player.position,
                   waypoints[waypointIndex],
                   speed);

                // If Enemy reaches position of waypoint he walked towards
                // then waypointIndex is increased by 1
                // and Enemy starts to walk to the next waypoint
                waypointIndex += 1;

            }

            if (simplifyLine)
            {
                line.Simplify(simplifyTolerance);
            }
            //line.enabled = false; //Making this script stop

        }
    }

    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex],
               speed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex])
            {
                waypointIndex += 1;
            }
        }
    }

}
