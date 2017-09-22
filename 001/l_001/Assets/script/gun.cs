using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {
	public Transform bellteObj;
	public int bellteSpeed = 45000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {  // reset position
			var newObj = Instantiate (bellteObj, transform.position, transform.rotation);
			var fwd = transform.TransformDirection(Vector3.forward);
			newObj.GetComponent<Rigidbody>().AddForce (fwd * bellteSpeed);
		}
	}
}
