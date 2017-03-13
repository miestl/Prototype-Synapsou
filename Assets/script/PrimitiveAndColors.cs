using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitiveAndColors : MonoBehaviour {

	//flemme de faire un enum
	string[] Primitive;

	// Use this for initialization
	void Start () {
		Primitive = new string[10];

		Primitive [0] = "Carre";
		Primitive [1] = "Cercle";
		Primitive [2] = "Losange";
		Primitive [3] = "Coeur";


		// or
		// cardSuit = (CardSuit)Enum.ToObject(typeof(CardSuit) , Random.Range(0, 3));
		int rng;

		rng = Random.Range (0, 4);

		Debug.Log (Primitive [rng]);


		/*Debug.Log (Primitive [0]);
		Debug.Log (Primitive [1]);
		Debug.Log (Primitive [2]);
		Debug.Log (Primitive [3]);*/
	}
	
	// Update is called once per frame
	void Update () {

	}
}
