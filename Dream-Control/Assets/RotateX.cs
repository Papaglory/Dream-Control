﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateX : MonoBehaviour {


    public float speed = 0.02f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(Vector3.right, speed * Time.deltaTime);
	}
}
