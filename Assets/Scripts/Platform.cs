using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	private void OnTriggerExit (Collider col) {
		if (col.gameObject.tag == "Player") {
			TileManager.tm.SpawnPlatform ();
			StartCoroutine (Fall());
		}
	}

	private IEnumerator Fall () {
		yield return new WaitForSeconds (1f);
		GetComponent<Rigidbody> ().isKinematic = false;

		yield return new WaitForSeconds (1f);
		TileManager.tm.Tiles.Push (gameObject);
		gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		gameObject.SetActive (false);
	}
}
