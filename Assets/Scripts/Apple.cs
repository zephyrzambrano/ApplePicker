﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
    [Header("Set in Inspector")]
    public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y<bottomY) {
            Destroy(this.gameObject);

            //get a reference to the ApplePicker component of the Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            //call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
	}
}
