using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public List<Color> backgroundColors = new List<Color>();

	// Use this for initialization
	void Start () {
        StartCoroutine(ChangeBackgroundColor());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator ChangeBackgroundColor()
    {

        Camera.main.backgroundColor = backgroundColors[Random.Range(0, backgroundColors.Count - 1)];

        yield return new WaitForSeconds(2);

        StartCoroutine(ChangeBackgroundColor());
    }
}
