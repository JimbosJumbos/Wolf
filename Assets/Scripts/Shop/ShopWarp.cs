﻿using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif

public class ShopWarp : MonoBehaviour {

	void OnTriggerEnter(Collider Col) {
		if (Col.tag == "Player") {
			SceneManager.LoadScene ("Shop");
		}
	}


}