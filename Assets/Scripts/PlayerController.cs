﻿using UnityEngine;
using System.Collections;

enum State { left, up, down, right };

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject ps;

	private State state = State.up;
	private Rigidbody rb;

	private void Start () {
		rb = GetComponent<Rigidbody>();
	}

	private void Update () {
		if (Input.GetMouseButtonDown (0)) {
			switch (state) {
			case State.left:
				state = State.up;
				rb.velocity = new Vector3 (-speed, 0f, 0f);
				break;
			case State.up:
				state = State.left;
				rb.velocity = new Vector3 (0f, 0f, -speed);
				break;
			}
		}
	}

	private void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "gem") {
			col.gameObject.SetActive (false);
			Instantiate (ps, col.gameObject.transform.position, Quaternion.Euler(new Vector3(270, 0, 0)));
		}
	}
	
}
