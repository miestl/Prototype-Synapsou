using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Math : MonoBehaviour {

	string[] result;
	string[] secondNumber;
	private bool[] state; // c'est provisoire calme toi franck_r !!!!!!!!!

	public GameObject getTheFirstNumber;
	public GameObject getSecondNumber;
	public GameObject getResult;
	// Use this for initialization
	void Start () {
		result =  new string[3];
		secondNumber = new string[3];
		state = new bool[3];

		result [0] = "2";
		result [1] = "5";
		result [2] = "8";

		secondNumber [0] = "1";
		secondNumber [1] = "3";
		secondNumber [2] = "4";

		state [0] = true;
		state [1] = false;
		state [2] = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (state [0] == true) {
			//Debug.Log ("passe");	
			getSecondNumber.GetComponent<InputField>().text = secondNumber [0];
			getResult.GetComponent<InputField> ().text = result [0];
			Debug.Log (secondNumber [0]);
			Debug.Log (result [0]);
			//Debug.Log (getTheFirstNumber.text);
			//Debug.Log (getResult.text);
			if (getTheFirstNumber.GetComponent<InputField>().text == "1") {
				state [0] = false;
				state [1] = true;
			}
		} else if (state [1] == true) {
			getSecondNumber.GetComponent<InputField>().text = secondNumber [1];
			getResult.GetComponent<InputField> ().text = result [1];
			if (getTheFirstNumber.GetComponent<InputField>().text == "2") {
				state [1] = false;
				state [2] = true;
			}
		}
		else if (state [2] == true) {
			getSecondNumber.GetComponent<InputField>().text = secondNumber [2];
			getResult.GetComponent<InputField> ().text = result [2];
			if (getTheFirstNumber.GetComponent<InputField>().text == "4") {
				//state [1] = false;
				state [2] = true;
			}
		}
	}
}
