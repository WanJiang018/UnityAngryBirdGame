using UnityEngine;
using System.Collections;

public class CollisionComponent_2 : MonoBehaviour {
	public AudioClip collisionSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnCollisionEnter(Collision theCollision)
	{
		if (theCollision.relativeVelocity.magnitude > 10) {
			gameObject.GetComponent<AudioSource>().PlayOneShot(collisionSound);
		}
	}

}
