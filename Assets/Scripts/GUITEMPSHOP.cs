using UnityEngine;
using System.Collections;

public class GUITEMPSHOP : MonoBehaviour {

	public GameObject ShopTracker;

	void Start() {
		ShopTracker = GameObject.FindGameObjectWithTag ("ShopController");
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label (new Rect (0, 0, 250, 20), "WELCOME TO THE SHOP!");
		GUI.Label (new Rect (0, 20, 250, 20), "YOU HAVE " + ShopTracker.GetComponent<ShopCurrencyTracker> ().playerCurrency.ToString () + " GRANGER MONEY");


	}
}
