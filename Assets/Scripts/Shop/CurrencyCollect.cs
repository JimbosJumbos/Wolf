using UnityEngine;
using System.Collections;

public class CurrencyCollect : MonoBehaviour {

	public GameObject ShopTracker;

	void Start() {
		ShopTracker = GameObject.FindGameObjectWithTag ("ShopController");
	}


	void OnTriggerEnter(Collider Col) {
		if (Col.tag == "Player") {
			ShopTracker.GetComponent<ShopCurrencyTracker> ().playerCurrency++;
		}

		Destroy (transform.gameObject);
	}
}
