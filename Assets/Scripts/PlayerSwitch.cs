using UnityEngine;
using System.Collections;

public class PlayerSwitch : MonoBehaviour {

	public Material Happy;
	public Material Sad;

	public GameObject player;

	// Update is called once per frame
	void Update () {

		if (player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl> ().keyChange == true) {
			GetComponent<Renderer> ().material = Sad;
		} else {
			GetComponent<Renderer> ().material = Happy;
		}
	
	}
}
