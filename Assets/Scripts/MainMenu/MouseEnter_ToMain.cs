using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif



public class MouseEnter_ToMain : MonoBehaviour {

	public Material normal;
	public Material mouseOver;
	public bool exitButton;


	void Start() {
		GetComponent<Renderer> ().material = normal;
	}

	void OnMouseEnter(){
		GetComponent<Renderer> ().material = mouseOver;
	}

	void OnMouseExit() {
		GetComponent<Renderer> ().material = normal;
	}

	void OnMouseUp(){
		if (exitButton) {
			Application.Quit ();
		} else {
			SceneManager.LoadScene("MainLevelDesign");
		}
	}

}
