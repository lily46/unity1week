using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Mathf.Abs(rigid.velocity.x) < 4f) {
			rigid.velocity = new Vector2(rigid.velocity.x * 0.95f, rigid.velocity.y);
		}
	}
}
