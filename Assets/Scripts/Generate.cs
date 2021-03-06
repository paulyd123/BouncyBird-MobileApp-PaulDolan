﻿using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject trees;
	int score = 0;
	int highScore;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 2.5f);
		highScore =PlayerPrefs.GetInt("High Score", highScore);

		if (score > 10) {
			InvokeRepeating("CreateObstacle", 1f, 1.5f);
		}
	}

	void Update()
	{
		if (score >= highScore)
		{
			highScore = score;
			PlayerPrefs.SetInt("High Score", highScore);
		}
	}
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" High Score: " + highScore.ToString());
		GUILayout.Label(" Score: " + score.ToString());
	}
	
	void CreateObstacle()
	{
		Instantiate(trees);
		score++;
	}

	/*void Start () {
		CanMute = true;
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (140, 20, 300, 300), "Mute")) {
			if (CanMute) {
				AudioListener.pause = true;
				CanMute = false;
			} else {
				AudioListener.pause = false;
				CanMute = true;
			}
		}
	}*/
}