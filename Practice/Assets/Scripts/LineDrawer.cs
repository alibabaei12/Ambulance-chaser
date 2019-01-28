using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer line;
    private Vector2 mousePosition;
    [SerializeField] private bool simplifyLine = false;
    [SerializeField] private float simplifyTolerance = 0.02f;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
        //line.SetPosition(0, mousePosition);
        //line.enabled = true;

    }
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) //Or use GetKey with key defined with mouse button
        {
            
            line.positionCount = 0;
            //line.SetPosition(line.positionCount - 1, mousePosition);
        }

        if (Input.GetMouseButton(0)) //Or use GetKey with key defined with mouse button
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (simplifyLine)
            {
                line.Simplify(simplifyTolerance);
            }
            //line.enabled = false; //Making this script stop

            //line.positionCount = 0;


        }
    }
    
}
