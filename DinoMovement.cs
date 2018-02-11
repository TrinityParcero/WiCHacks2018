using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trinity parcero
//controls dino movement and jumping
//this goes on a dino object
public class DinoMovement : MonoBehaviour
{

    //fields
    public SceneManager sceneMan;
	public Dino dino;
	public int moveDelay;
    //set positions in inspector
	public Vector3[] positions;

    // Use this for initialization
    void Start()
    {
		moveDelay = 0;
		//sceneMan = GetComponent<SceneManager> ();
		positions = new Vector3[30];
		positions [0] = new Vector3 (-5, -3, 0);
		positions [1] = new Vector3 (0, -3, 0);
		positions [2] = new Vector3 (5, -3, 0);

    }

    // Update is called once per frame
    void Update()
    {
		if (moveDelay == 30) 
		{
			SetLoc ();
			Move ();
			moveDelay = 0;
		} 
		else 
		{
			moveDelay++;
		}
    }

    //checks for input of commands
    public void SetLoc()
    {
        //input is move right
        if(sceneMan.ReadInput() == dino.rightCommand)
        {
            //if on right edge, loop round to position 1
            if(dino.loc == 2)
            {
                dino.loc = 0;
            }
            else
            {
                dino.loc++;
            }
        }
        //input is move left
        else if(sceneMan.ReadInput() == dino.leftCommand)
        {
            //if on left edge, loop round to position 3
            if(dino.loc == 0)
            {
                dino.loc = 2;
            }
            else
            {
                dino.loc--;
            }
        }
        //input is jump
        else if(sceneMan.ReadInput() == dino.jumpCommand)
        {
            //if in lane 1, jump above that space
            if(dino.loc == 0)
            {
                dino.loc = 3;
            }
            //and so on
            if(dino.loc == 1)
            {
                dino.loc = 4;
            }
            //and so forth
            if(dino.loc == 2)
            {
                dino.loc = 5;
            }
        }
    }

    //uses loc to set actual position
    public void Move()
    {
        dino.transform.position = positions[dino.loc];
    }
    

    

   

    
}