using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private Button shootBtn;

    [SerializeField] private GameObject needle;
    private GameObject[] needles;

    [SerializeField] private int howManyNeedles;
    private float needleDistance = 1.5f;
    private int needleIndex;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
