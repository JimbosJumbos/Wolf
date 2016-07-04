using UnityEngine;
using System.Collections;

public class GUITEMP : MonoBehaviour {

	public GameObject player;
	public GameObject ShopTracker;

	// Use this for initialization
	void Start () {
		ShopTracker = GameObject.FindGameObjectWithTag ("ShopController");
	}
	
	// Update is called once per frame
	void OnGUI () {
		float current = player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController> ().deltaKey;
		if (current > 0f) {
			GUI.Label (new Rect (0, 0, 100, 100), current.ToString());
		}

		GUI.Label (new Rect (0, 50, 100, 100), ShopTracker.GetComponent<ShopCurrencyTracker> ().playerCurrency.ToString());
	}
}
