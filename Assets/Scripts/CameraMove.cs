using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	[SerializeField]
	GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			transform.position =  new Vector3(target.transform.position.x, 0,  -10);
		}
	}
}
