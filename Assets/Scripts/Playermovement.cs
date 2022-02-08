using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public CharacterController2D controller2D;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;

    // update called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    

    }

    void FixedUpdate()
    {
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }


}

