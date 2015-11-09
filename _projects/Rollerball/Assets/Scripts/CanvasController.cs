using UnityEngine;
using System.Collections;

public class CanvasController : MonoBehaviour {


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void LoadShop()
    {
        Application.LoadLevel("Shop");
    }

    public void BackToMiniGame()
    {
        Application.LoadLevel("Minigame");
    }
}
