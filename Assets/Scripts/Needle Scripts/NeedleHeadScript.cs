using UnityEngine;
using System.Collections;

public class NeedleHeadScript : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Needle Head")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f; // Time stops and game stops
        }
    }
}
