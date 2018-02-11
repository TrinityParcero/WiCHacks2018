using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//click method for play button
//goes to main game state
public class PlayButton : MonoBehaviour 
{
	public Button playButton;
	// Use this for initialization
	void Start () 
	{
		playButton.onClick.AddListener(TaskOnClick);

	}
	
	// Update is called once per frame
	void Update () 
	{
		

	}

	public void TaskOnClick()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("gamePlay");	
	}	
		
}
