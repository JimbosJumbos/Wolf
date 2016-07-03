using UnityEngine;
using System.Collections;

public class ZombieFollowSimple : MonoBehaviour {

	public GameObject player;
	Vector3 move;
	float dX;
	float dZ;
	public float deltaSpeed;
	public bool moveToPlayer = false;

	public Material MADZOMBIE;
	public Material HAPPYZOMBIE;

	public GameObject respawn;

	void LateUpdate(){

		if (moveToPlayer) {

			GetComponent<Renderer> ().material = MADZOMBIE;

			move = player.transform.position - transform.position;

			dX = (move.x / Mathf.Abs (move.x)) * deltaSpeed;
			dZ = (move.z / Mathf.Abs (move.z)) * deltaSpeed;


			transform.position = new Vector3 (transform.position.x + dX, transform.position.y, transform.position.z + dZ);
		} else {
			GetComponent<Renderer> ().material = HAPPYZOMBIE;
		}
	}

	void OnTriggerEnter(Collider Col){
		if (Col.tag == "Player") {
			transform.position = respawn.transform.position;
			Application.Quit ();
		}
	}

}
