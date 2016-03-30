using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject trees;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 2.5f);
	}
	
	void CreateObstacle()
	{
		Instantiate(trees);
	}
}