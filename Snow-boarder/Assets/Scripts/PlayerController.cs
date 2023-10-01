using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float fltorqueAmount = 1f;
    [SerializeField] float flboostSpeed = 30f;
    [SerializeField] float flbaseSpeed = 20f;
    
    Rigidbody2D rbrb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool bolcanMove = true;
    void Start()
    {
       rbrb2d =  GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bolcanMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        bolcanMove = false;
    }

     void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = flboostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = flbaseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbrb2d.AddTorque(fltorqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rbrb2d.AddTorque(-fltorqueAmount);
        }
    }
}
