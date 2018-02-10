using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trinity parcero
//dino object
public class Dino : MonoBehaviour
{

    //fields
    public string name;
    //loc is held in int, basically index for
    //accessing array of actual positions
    public int loc;
    

    // Use this for initialization
    void Start()
    {
        loc = 1; //start in middle row
        name = "dino";
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