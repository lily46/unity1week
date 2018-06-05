using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	[SerializeField]
	GameObject target;

	private Vector3 offset = Vector3.zero;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			Vector3 newPosition = transform.position;
			newPosition.x = target.transform.position.x + offset.x;
			newPosition.y = target.transform.position.y + offset.y;
			//transform.position = newPosition;
			transform.position = Vector3.Lerp(transform.position, newPosition, 2.0f * Time.deltaTime);

		}
	}
}
