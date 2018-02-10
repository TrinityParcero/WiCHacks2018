using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//trinity parcero
//controls scene level processes
public class SceneManager : MonoBehaviour
{

    //fields
    public InputField mainInputField;
    public Dino dinosaur;

    //set positions in inspector
    public Vector3[] positions;

    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Enter))
        {
            ReadInput();
        }
    }

    //gets input and saves it as a string
    public void GetInput()
    {
        string input = (mainInputField.text).Trim();
    }

    //reads input and returns it if it is a valid command
    public string ReadInput(string input)
    {
        if(input == dinosaur.rightCommand)
        {
            return dinosaur.rightCommand;
        }
        else if(input == dinosaur.leftCommand)
        {
            return dinosaur.leftCommand;
        }
        else if(input == dinosaur.jumpCommand)
        {
            return dinosaur.jumpCommand;
        }
    }
}