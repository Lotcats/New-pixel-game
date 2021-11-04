using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
   
    public CharacterController2D controller;
    public float RunSpeed = 500f;   //I think 200 runspeed is decent right now

    float HorizontalMove = 0f;
    bool jump = false;

      void Update ()  {

      HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate ()
    { 
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
