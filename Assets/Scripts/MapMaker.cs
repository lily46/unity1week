using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour {

	[SerializeField]
	GameObject normalTip;

	// Use this for initialization
	void Start () {
		for(int x = 0; x < 10; ++x) {
			Instantiate(normalTip, new Vector3(x, -0.1f * x, 0), Quaternion.identity);
		}

		for (int x = 0; x < 10; ++x) {
			var obj = Instantiate(normalTip, new Vector3(x + 10f, -0.1f * (x + 10), 0), Quaternion.identity);
			obj.transform.localEulerAngles = new Vector3(0, 0, -10f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
