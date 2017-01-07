using UnityEngine;
using System.Collections;

public class Balloon : MonoBehaviour {

    public float speed = 0.025f;
    public int rotation = -1;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(BalloonUp());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator BalloonUp()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position + transform.up, speed);

        yield return new WaitForSeconds(0);

        StartCoroutine(BalloonUp());
    }
}
