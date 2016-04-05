using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	
	public Canvas MainCanvas;

	
	public void LoadOn()
	{
		Application.LoadLevel("Game");
	}

	void Update() {
		if (Input.GetKey("exit"))
			Application.Quit();
		
	}
}