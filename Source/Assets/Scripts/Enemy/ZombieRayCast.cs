using UnityEngine;
using System.Collections;

public class ZombieRayCast : MonoBehaviour {

	public GameObject player;
	public float firstSpot = 7.5f;
	bool spotted = false;
	public float loseSpot = 1f;
	float curretViewDistance;

	void Update(){


		Vector3 direction = player.transform.position - transform.position;

		RaycastHit ray;
		#if UNITY_EDITOR
		Debug.DrawRay (transform.position, direction, Color.green);
		#endif
		Ray ViewRay = new Ray(transform.position, direction);


		if (spotted == true) {
			curretViewDistance = loseSpot;
		} else {
			curretViewDistance = firstSpot;
		}
			

		if (Physics.Raycast (ViewRay, out ray, curretViewDistance)) {
			if (ray.collider.tag == "Player") {
				GetComponent<ZombieFollowSimple> ().moveToPlayer = true;
				spotted = true;
				player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().keyChange = true;
				player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().deltaKey = 5f;
			} else {
				spotted = false;
				GetComponent<ZombieFollowSimple> ().moveToPlayer = false;
			}
		} else {
			spotted = false;
			GetComponent<ZombieFollowSimple> ().moveToPlayer = false;
		}


			
			
	}

}
