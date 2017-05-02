using UnityEngine;
using System.Collections;
using UnityEngine.UI; // we need to reference text
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private Text scoreText;
    private int score;
	// Use this for initialization
	void Awake ()
	{

	    scoreText = GameObject.Find("Score Text").GetComponent<Text>();
	    if (instance == null)
	        instance = this;
	}
	
	// Update is called once per frame
	public void SetScore ()
	{

	    score++;
	    scoreText.text = "" + score;
	}
}
