using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//trinity parcero
//controls scene level processes
public class SceneManager : MonoBehaviour
{

    //fields
    public InputField mainInputField;
    public Dino dinosaur;
    public int counter;
    public int score;
    public int playerHealth;
    public GameObject[] enemiesOnScreen;

    //set positions in inspector
    public Vector3[] positions;

    // Use this for initialization
    void Start()
    {
        counter = 0;
        playerHealth = 3;

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 60)
        {
            score += 100;
            counter = 0;
        }
        else
        {
            counter += 1;
        }

		if (Input.GetKey(KeyCode.Return))
        {
            //disable the text field
			mainInputField.DeactivateInputField();

            //read the input
            ReadInput();
        }
		mainInputField.ActivateInputField ();
    }
    

    //reads input and returns it if it is a valid command
    public string ReadInput()
    {
		if(mainInputField.text == dinosaur.rightCommand)
        {
            return dinosaur.rightCommand;
        }
		else if(mainInputField.text == dinosaur.leftCommand)
        {
            return dinosaur.leftCommand;
        }
        else if(mainInputField.text == dinosaur.jumpCommand)
        {
            return dinosaur.jumpCommand;
        }
        else
        {
            return "dino doesn't know how to do that!";
        }
    }

	public void LoadScene(Scene sceneName)
	{


		
}