using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showCursor : MonoBehaviour {

    private void Awake()
    {
        Cursor.visible = false;
    }

    // Use this for initialization
    void Start () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
