using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
public float lifetime = 0;

	void Start () {
		Destroy (gameObject,lifetime);
	}


	void Update () {

	}
}
