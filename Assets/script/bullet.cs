using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    Rigidbody rb;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        Vector3 ajustedMovement = transform.TransformDirection(Vector3.forward);
        rb.AddForce(ajustedMovement * 1000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
