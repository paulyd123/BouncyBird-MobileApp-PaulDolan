using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Generates : MonoBehaviour
{
	public GameObject trees;
	public GameObject rocks;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 2.5f);
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	void CreateObstacle()
	{
		Instantiate(trees);
		Instantiate(rocks);
	}
}