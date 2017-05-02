using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
    public void PlayGame()
    {
        Application.LoadLevel("GamePlay");
    }
}
