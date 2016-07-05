using UnityEngine;
using System.Collections;

public class NoDestroyOnChange : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
}
