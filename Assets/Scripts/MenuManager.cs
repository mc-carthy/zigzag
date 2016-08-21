using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public GameObject menu;

	private bool isOnScreen = false;

	private void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			ToggleMenu ();
			isOnScreen = !isOnScreen;
		}
	}

	public void ToggleMenu () {
		if (isOnScreen) {
			menu.SetActive (false);
		} else {
			menu.SetActive (true);
		}
	}

	public void ReloadScene () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
		menu.SetActive (false);
	}
}
