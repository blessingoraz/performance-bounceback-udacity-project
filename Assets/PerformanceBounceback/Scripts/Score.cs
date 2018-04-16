using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
	public Text text;
	private int previousScore = 0;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		text = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.score != previousScore) {
			previousScore = gameManager.score;
			UpdateScore();
		}
       
	}

	private void UpdateScore() {
		text.text = "Score: " + gameManager.score.ToString();
	}
}
