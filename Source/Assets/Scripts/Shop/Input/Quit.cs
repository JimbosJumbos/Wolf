using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

#if UNITY_EDITOR 
using UnityEditor.SceneManagement;
#endif


public class Quit : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("ShopQuit")) {
			SceneManager.LoadScene ("StartLevelDesign");
		}
	}
}
