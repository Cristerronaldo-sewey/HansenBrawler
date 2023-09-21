using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KongElvis : Player
{
    public Hand LeftHand;
    public Hand RightHand;
    public Foot LeftFoot;
    public Foot RightFoot;
    public Body MainBody;

    public Head BodyHead;

    //Move forward method 
    public void MoveForward()
    {
        //Move forward
        transform.Translate(Vector3.forward  * Time.deltaTime);
    }
    //Move backward method 
    public void MoveBackward()
    {
        //Move Backward
        transform.Translate(Vector3.back  * Time.deltaTime);

    }

    public void Update()
    {
        // Detect when you want to trigger the punch animation, for example, by pressing a button.
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Set the "Punch" trigger to transition to the punch animation state.
            Punch();
        }
    }

    public void Punch()
    {
        //punch
        Animator animator = GetComponent<Animator>();

        animator.SetTrigger("Punch");

    }

}
