using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bellte : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3);
	}
	void OnCollisionEnter(Collision other)
	{
		Destroy (gameObject, 3);
//		DestroyObject (other.gameObject);

	}

}
