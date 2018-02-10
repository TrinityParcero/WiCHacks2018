using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trinity parcero
//controls dino movement and jumping
//this goes on a dino object
public class DinoMovement : MonoBehaviour
{

    //fields
    private string rightCommand;
    private string leftCommand;
    private string jumpCommand;
    public GameObject screenMan;

    //set positions in inspector
    public Vector3[] positions;

    // Use this for initialization
    void Start()
    {
        //set commands based on dinos name
        rightCommand = (name + ".MoveRight();");
        leftCommand = (name + ".MoveLeft();");
        jumpCommand = (name + ".Jump();");

    }

    // Update is called once per frame
    void Update()
    {
        SetLoc();
        Move();
    }

    //checks for input of commands
    public void SetLoc()
    {
        //input is move right
        if(screenMan.GetInput() == rightCommand)
        {
            //if on right edge, loop round to position 1
            if(loc == 2)
            {
                loc = 0;
            }
            else
            {
                loc++;
            }
        }
        //input is move left
        else if(screenMan.GetInput() == leftCommand)
        {
            //if on left edge, loop round to position 3
            if(loc == 0)
            {
                loc = 2;
            }
            else
            {
                loc--;
            }
        }
        //input is jump
        else if(screenMan.GetInput() == jumpCommand)
        {
            //if in lane 1, jump above that space
            if(loc == 0)
            {
                loc = 3;
            }
            //and so on
            if(loc == 1)
            {
                loc = 4;
            }
            //and so forth
            if(loc == 2)
            {
                loc = 5;
            }
        }
    }

    //uses loc to set actual position
    public void Move()
    {
        transform.position = positions[loc];
    }
    

    

   

    
}