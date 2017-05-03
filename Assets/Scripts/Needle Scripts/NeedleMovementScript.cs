using UnityEngine;
using System.Collections;

public class NeedleMovementScript : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
    private GameObject needleBody;

    private bool canFireNeedle; //initially equal to false
    private bool touchedTheCircle;
    private float forceY = 20f;
    private Rigidbody2D myBody;

    void Awake()
    {
        Initialize();
        //FireTheNeedle();

    }

    void Initialize()
    {
        needleBody.SetActive(false);
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (canFireNeedle)
            myBody.velocity = new Vector2(0, forceY);

    }

    public void FireTheNeedle()
    {
        needleBody.SetActive(true);
        myBody.isKinematic = false; //if it's true => physics is not affecting it
        canFireNeedle = true;
    }

    void OnTriggerEnter2D(Collider2D target) //target -> game object that we touched
    {
        if (touchedTheCircle) //already touched ?
        {
            return;
        }
        if (target.tag =="Circle")
        {
            canFireNeedle = false;
            touchedTheCircle = true;

            myBody.isKinematic = true; //to pin out game object, we dont want our game object moving
            gameObject.transform.SetParent(target.transform);

            if (ScoreManager.instance !=null)
            {
                ScoreManager.instance.SetScore();
            }
            //if (GameManager.instance != null) // another way yo create needles
            //{
            //    GameManager.instance.InstantiateNeedle();
            //}
        }
    }
}
