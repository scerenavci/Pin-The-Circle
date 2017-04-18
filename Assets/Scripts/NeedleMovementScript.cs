using UnityEngine;
using System.Collections;

public class NeedleMovementScript : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
    private GameObject needleBody;

    private bool canFireNeedle; //initially equal to false
    private bool touchedTheCircle;
    private float forceY = 70f;
    private Rigidbody2D myBody;

    void Awake()
    {
        Initialize();

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
        myBody.isKinematic = false; //it it' true => physics is not affecting it
        canFireNeedle = true;
    }
}
