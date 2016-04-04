using UnityEngine;

public class Generate : MonoBehaviour
{
<<<<<<< HEAD
	public GameObject trees;
=======
	public GameObject rocks;
>>>>>>> origin/master
	
	// Use this for initialization
	void Start()
	{
<<<<<<< HEAD
		InvokeRepeating("CreateObstacle", 1f, 2.5f);
=======
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
>>>>>>> origin/master
	}
	
	void CreateObstacle()
	{
<<<<<<< HEAD
		Instantiate(trees);
=======
		Instantiate(rocks);
>>>>>>> origin/master
	}
}