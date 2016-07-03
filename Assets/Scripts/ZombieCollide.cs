using UnityEngine;
using System.Collections;

public class ZombieCollide : MonoBehaviour {


	void OnTriggerEnter(Collider Col){
		if (Col.tag == "Player") {

			this.GetComponent<ZombieFollowSimple> ().moveToPlayer = false;
		}
	}

	void OnTriggerExit(Collider Col) {
		if (Col.tag == "Player") {

			this.GetComponent<ZombieFollowSimple> ().moveToPlayer = true;
		}
	}

}
