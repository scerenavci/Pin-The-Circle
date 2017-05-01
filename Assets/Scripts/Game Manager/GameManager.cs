using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private Button shootBtn;

    [SerializeField] private GameObject needle;
    private GameObject[] gameNeedles;

    [SerializeField] private int howManyNeedles;
    private float needleDistance = 0.5f;
    private int needleIndex;
	// Use this for initialization
	void Awake () {

	    if (!instance)
	        instance = this; // this = GameManager class
        GetButton();
	}
	
	// Update is called once per frame
	void Start () {
	
        CreateNeedles();
	}

    void GetButton()
    {
        shootBtn = GameObject.Find("Shoot Button").GetComponent<Button>(); // button is not a game object, is a component -> Find("name")
        shootBtn.onClick.AddListener(() => ShootTheNeedle());
    }

    public void ShootTheNeedle()
    {
        gameNeedles[needleIndex].GetComponent<NeedleMovementScript>().FireTheNeedle();
        needleIndex++;

        if (needleIndex == gameNeedles.Length)
        {
            Debug.Log("The game is finished");
            shootBtn.onClick.RemoveAllListeners();
        }
    }

    void CreateNeedles()
    {
        gameNeedles = new GameObject[howManyNeedles];
        Vector3 temp = transform.position;

        for (int i = 0; i < gameNeedles.Length; i++)
        {
            gameNeedles[i] = Instantiate(needle, temp, Quaternion.identity) as GameObject;
            temp.y -= needleDistance;
        }
    }

    public void InstantiateNeedle()
    {
        Instantiate(needle, transform.position, Quaternion.identity);
    }
}
