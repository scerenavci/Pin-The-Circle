using UnityEngine;
using System.Collections;

public class CircleRotateScript : MonoBehaviour
{

    [SerializeField]
    private float rotationSpeed = 50f;

    private bool canRotate;

    private float angle;
    // Use this for initialization
	void Awake ()
	{
	    canRotate = true;
	    StartCoroutine(ChangeRotation());
	}
	
	// Update is called once per frame
	void Update () {

	    if (canRotate)
	    {
	        RotateTheCircle();
	    }
	}

    IEnumerator ChangeRotation()
    {
        yield return new WaitForSeconds(2f);

        if (Random.Range(0, 2) > 0)
            rotationSpeed = -Random.Range(50, 100);
        else
            rotationSpeed = Random.Range(50, 100);

        StartCoroutine(ChangeRotation());
    }

    void RotateTheCircle()
    {
        angle = transform.rotation.eulerAngles.z; // we only need to rotate the z angle because it's not a 3D game
        angle += rotationSpeed * Time.deltaTime; //time between each frame
        transform.rotation = Quaternion.Euler (new Vector3(0,0,angle));
    }
}
