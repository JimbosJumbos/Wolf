using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject target;
	Vector3 offset;

	void Start () {
		offset = transform.position - target.transform.position;
	}
		
	void LateUpdate() {
		Vector3 desiredPosition = target.transform.position + offset;
		transform.position = desiredPosition;
	}
}

