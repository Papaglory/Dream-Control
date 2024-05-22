using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    float increaseSpeed = 1;
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAroundLocal(-Vector3.up, (0.1f * increaseSpeed) * Time.deltaTime);
        increaseSpeed += 0.01f;
	}
}
