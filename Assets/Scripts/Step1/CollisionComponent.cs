using UnityEngine;
using System.Collections;

public class CollisionComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter(Collision theCollision)
	{
		Debug.Log ("I Collided");
	}

}
