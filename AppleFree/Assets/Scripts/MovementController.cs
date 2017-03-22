using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    private Rigidbody body;

    public float speed;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(h, 0, v);

        body.AddForce(Time.deltaTime * speed * movementVector);
        body.AddTorque(Time.deltaTime * speed * v, 0, -Time.deltaTime * speed * h);
    }
}
