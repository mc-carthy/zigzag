using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {

	public GameObject platform;
	public int numOfPlatforms = 20;

	private GameObject lastPlatform;

	private static TileManager TM;
	public static TileManager tm {
		get {
			if (TM == null) {
				TM = GameObject.FindObjectOfType<TileManager> ();
			}
			return TM;
		}
	}

	private void Start () {
		lastPlatform = Instantiate (platform) as GameObject;
		lastPlatform.transform.SetParent (this.transform);

		for (int i = 0; i < numOfPlatforms; i++) {
			SpawnPlatform ();
		}
	}

	public void SpawnPlatform () {
		int random = Random.Range (0, 2);

		if (random == 0) {
			lastPlatform = Instantiate (platform, new Vector3 (lastPlatform.transform.position.x - 1, lastPlatform.transform.position.y, lastPlatform.transform.position.z), Quaternion.identity) as GameObject;
		} else {
			lastPlatform = Instantiate (platform, new Vector3 (lastPlatform.transform.position.x, lastPlatform.transform.position.y, lastPlatform.transform.position.z + 1), Quaternion.identity) as GameObject;
		}
		lastPlatform.transform.SetParent (this.transform);
	}
}
