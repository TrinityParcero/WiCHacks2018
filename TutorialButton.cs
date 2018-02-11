using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//tutorial button
//click method for tutorial button
public class TutorialButton : MonoBehaviour 
{
	public Button tutorialButton;
	// Use this for initialization
	void Start () 
	{
		tutorialButton.onClick.AddListener (TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void TaskOnClick()
	{
	  UnityEngine.SceneManagement.SceneManager.LoadScene("tutorial");
	}
}
