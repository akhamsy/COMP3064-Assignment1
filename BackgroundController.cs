using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : BackgroundController.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/30/2016
 * Date Last Modified : 10/30/2016
 * Description		  : Controls background
 * Revision			  : 1.0
 * */

public class BackgroundController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.015f;

	private Transform _transform;
	private Vector2 _currentPosition;


	//Initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();

	}

	// Update is called once per frame
	void Update () {

		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -20f) {
			Reset ();

		}
	}

    //Reset background to start once end is reached
	private void Reset(){

		_currentPosition = new Vector2 (20f, -0.03f);
		_transform.position = _currentPosition;

	}
}
