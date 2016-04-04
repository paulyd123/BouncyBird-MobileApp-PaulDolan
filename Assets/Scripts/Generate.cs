using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject trees;
	int score = 0;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 2.5f);
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Score: " + score.ToString());
	}
	
	void CreateObstacle()
	{
		Instantiate(trees);
		score++;
	}
}