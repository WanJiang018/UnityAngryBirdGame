﻿using UnityEngine;
using System.Collections;

public class ThrowComponent_2 : MonoBehaviour {
	public GameObject BallPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Fire1")) {
			GameObject newobj=GameObject.Instantiate(BallPrefab) as GameObject;
			newobj.GetComponent<Rigidbody>().position=this.gameObject.transform.position;
			newobj.GetComponent<Rigidbody>().velocity=this.gameObject.transform.forward;
		}
	}
}
