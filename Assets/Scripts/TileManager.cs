using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileManager : MonoBehaviour {

	public GameObject platform;
	public int numOfPlatforms = 20;

	private GameObject lastPlatform;

	private Stack<GameObject> tiles = new Stack<GameObject> ();
	public Stack<GameObject> Tiles {
		get {
			return tiles;
		}
		set {
			tiles = value;
		}
	}

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

	public void CreateTiles () {
		tiles.Push (Instantiate (platform));
		tiles.Peek ().SetActive (false);
	}

	public void SpawnPlatform () {

		if (tiles.Count < 1) {
			CreateTiles ();
		}

		int random = Random.Range (0, 2);

		if (random == 0) {
			GameObject temp = tiles.Pop ();
			temp.SetActive (true);
			temp.transform.position = new Vector3 (lastPlatform.transform.position.x - 1, lastPlatform.transform.position.y, lastPlatform.transform.position.z);
			lastPlatform = temp;
		} else {
			GameObject temp = tiles.Pop ();
			temp.SetActive (true);
			temp.transform.position = new Vector3 (lastPlatform.transform.position.x, lastPlatform.transform.position.y, lastPlatform.transform.position.z + 1);
			lastPlatform = temp;
		}

		/*
		if (random == 0) {
			lastPlatform = Instantiate (platform, new Vector3 (lastPlatform.transform.position.x - 1, lastPlatform.transform.position.y, lastPlatform.transform.position.z), Quaternion.identity) as GameObject;
		} else {
			lastPlatform = Instantiate (platform, new Vector3 (lastPlatform.transform.position.x, lastPlatform.transform.position.y, lastPlatform.transform.position.z + 1), Quaternion.identity) as GameObject;
		}
		*/
		lastPlatform.transform.SetParent (this.transform);
	}
}
