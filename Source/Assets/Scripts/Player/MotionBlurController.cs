using UnityEngine;
using System.Collections;

public class MotionBlurController : MonoBehaviour {

	public GameObject player;
	public bool active = false;

	// Update is called once per frame
	void Update () {

		if (active == false) {
			
			if (player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().keyChange) {
				active = true;
				GetComponent<UnityStandardAssets.ImageEffects.MotionBlur> ().enabled = true;
				GetComponent<UnityStandardAssets.ImageEffects.NoiseAndGrain> ().enabled = true;
			} 
		} else {
			if (!player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().keyChange) {
				active = false;;
				GetComponent<UnityStandardAssets.ImageEffects.MotionBlur> ().enabled = false;
				GetComponent<UnityStandardAssets.ImageEffects.NoiseAndGrain> ().enabled = false;
			} 
		}
	
	}
}
