using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OliveOilMovement : MonoBehaviour {
public float moveSpeed;
public GameObject deathParticles;

private Vector3 input;
private Vector3 spawn;
private float maxSpeed = 5f;
public AudioClip oliveDies;
public AudioSource soundSource;

	void Start () {
spawn = transform.position;
soundSource.clip = oliveDies;

	}

	void Update () {
			input = new Vector3(Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if(	GetComponent<Rigidbody>().velocity.magnitude < maxSpeed){
		GetComponent<Rigidbody>().AddForce(input* moveSpeed);
		}
			if(transform.position.y < -3){
					soundSource.Play();
			Die();
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.transform.tag == "Enemy"){
				soundSource.Play();
		Die();
		}
			if(other.transform.tag == "Goal"){

		GameManager.CompleteLevel();
	}
	}
		void Die(){
			Instantiate(deathParticles, transform.position, Quaternion.identity); //ensures no rotation
			transform.position = spawn;
	}
}
