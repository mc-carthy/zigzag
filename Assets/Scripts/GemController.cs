using UnityEngine;
using System.Collections;

public class GemController : MonoBehaviour {

	public float rotationSpeed = 150f;

	private void Update () {
		transform.RotateAround (transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
