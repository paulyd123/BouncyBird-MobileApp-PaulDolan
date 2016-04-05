using UnityEngine;

public class flying : MonoBehaviour
{
<<<<<<< HEAD
	//This is for when the space bar is pressed so the bird will jump
=======
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
>>>>>>> origin/master
	public Vector2 jumpForce = new Vector2(0, 300);
	
	// Update is called once per frame
	void Update ()
	{
		// Jump
		if (Input.GetKeyUp("space"))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
		
<<<<<<< HEAD
		// Dies when goes off screen
=======
		// Die by being off screen
>>>>>>> origin/master
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	
<<<<<<< HEAD
	// Dies by colliding
=======
	// Die by collision
>>>>>>> origin/master
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
<<<<<<< HEAD


=======
>>>>>>> origin/master
}