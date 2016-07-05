using UnityEngine;
using System.Collections;

public class LoadPlayerSpawn : MonoBehaviour {

	public GameObject playerSpawn;



	// Use this for initialization
	void OnLevelWasLoaded ( int level) {
		if (level == 4) {
			playerSpawn = GameObject.FindGameObjectWithTag ("PlayerSpawn");
			transform.position = playerSpawn.transform.position;
		}
	}

}
