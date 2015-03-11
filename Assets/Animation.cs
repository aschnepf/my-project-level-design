using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (grounded) {
			
			if (Input.GetKey) 
			{ 
				player.animation.Play("walk"); 
			} 

			else 
			{ 
				player.animation.Play("idle"); 
			} 
			

		}
	}
}
