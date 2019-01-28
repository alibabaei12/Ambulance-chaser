﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public Transform player;
    private Rigidbody2D rb;


    private void Start()
    {
          rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) *
            Mathf.Rad2Deg - 90;

        transform.eulerAngles = new Vector3(0, 0, z);

        rb.AddForce(gameObject.transform.up * speed);

    }
}
