using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	[SerializeField]
	GameObject ball;

	[SerializeField]
	Camera camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			ball.transform.position = new Vector3(0, 3, 0);
			ball.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
		}

		if (Input.GetKeyDown(KeyCode.Z)) {
			ball.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(100, 500));
		}

		if (Input.GetKey(KeyCode.A)) {
			camera.orthographicSize += 0.1f;
		}

		if (Input.GetKey(KeyCode.S)) {
			camera.orthographicSize -= 0.1f;
		}
	}
}
