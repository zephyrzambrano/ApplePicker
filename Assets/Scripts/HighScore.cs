using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need this line for uGUI to work

public class HighScore : MonoBehaviour {
    static public int score = 1000;

    void Awake() {
        //if the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScore")) {
            score = PlayerPrefs.GetInt("HighScore");
        }

        //assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
	}
}
