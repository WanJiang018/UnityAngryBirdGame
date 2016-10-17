using UnityEngine;
using System.Collections;

public class ThrowComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Fire1")) {
			Debug.Log ("Fire");
		}
	}
}
