using UnityEngine;
using System.Collections;

public class EthanWalk : MonoBehaviour {

	public float running = 0f;
	public bool jump = false;

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().movementSettings.isRunning) {
			GetComponent<Animator> ().SetFloat ("Forward", 1f, 0.1f, Time.deltaTime);
		} else {
			GetComponent<Animator> ().SetFloat ("Forward", 0f, 0.1f, Time.deltaTime);
		}

		transform.position = player.transform.position + new Vector3(0,-1.2f,0);

	}
}
