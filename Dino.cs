using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trinity parcero
//dino object
public class Dino : MonoBehaviour
{

    //fields
    public string name;
    public string rightCommand;
    public string leftCommand;
    public string jumpCommand;
    //loc is held in int, basically index for
    //accessing array of actual positions
    public int loc;
    public bool isJumping;
    

    // Use this for initialization
    void Start()
    {
        name = "dino"; //default name
        //set commands based on dinos name
        rightCommand = (name + ".MoveRight();");
        leftCommand = (name + ".MoveLeft();");
        jumpCommand = (name + ".Jump();");

        loc = 1; //start in middle row

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //sets a name for dino
    public void SetName()
    {
        //stretch goal to have a "settable name"
    }
    
}