using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMobility : MonoBehaviour
{
    public float speed;
    public float input;
    public Vector3 position;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        position = transform.position;
        /*
        
        //find the mouce posion and store it
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // get the rotation of the car
        //quaternion lets us look at what we wanna look at
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        //set the rotation of our car to the rotaion of where we look
        transform.rotation = rot;

        //next line makes the car not shrink when moving the mouse away 
        //from the car (only want z rotation and not x and y rotation)
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        //rigidbody2D.angularVelocity = 0;
        
        rb.angularVelocity = 0;

        //making the car move forward
 
        //going forward
        input = Input.GetAxis("Vertical");
        rb.AddForce(transform.up * speed * input);
        */
    }
}
