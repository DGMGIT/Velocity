﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public Transform transGun;
    public Transform gun;
    public GameObject bullet;
    public KeyCode up = KeyCode.T;
    public KeyCode down = KeyCode.G;
    public KeyCode shoot = KeyCode.B;


    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

        if (Input.GetKey(up))
        {
            transGun.RotateAround(transGun.position, transGun.right, -2);
        }

        else if (Input.GetKey(down))
        {
            transGun.RotateAround(transGun.position, transGun.right, 2);
        }
        
        else if (Input.GetKeyDown(shoot))
        {
        Instantiate(bullet, gun.position, gun.rotation);
        }
    }
}
