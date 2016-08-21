using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

	private ParticleSystem ps;

	private void Start () {
		ps = GetComponent<ParticleSystem> ();
	}

	private void Update () {
		if (!ps.isPlaying) {
			Destroy (this.gameObject);
		}
	}
}
