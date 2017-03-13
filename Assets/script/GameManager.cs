using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void StartToLearn()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void Math()
	{
		SceneManager.LoadScene ("Math");
	}

	public void Geometry()
	{
		SceneManager.LoadScene ("Geometry");
	}
}
