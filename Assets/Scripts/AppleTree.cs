using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]

    //prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which the AppleTree moves
    public float speed = 1f;

    //distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;

    //rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		//dropping apples every second
	}
	
	// Update is called once per frame
	void Update () {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        
        //changing direction
        if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); //move right   
        }
        else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed); //move left
        }
	}
}
