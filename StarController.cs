using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : StarController.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/30/2016
 * Date Last Modified : 10/30/2016
 * Description		  : Controls star sprite
 * Revision			  : 1.0
 * */

public class StarController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.05f;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -5) {
			Reset ();
		}
	}

	public void Reset(){ //reset star
		float xpos = Random.Range (6f, 20f);
		float ypos = Random.Range (-2.5f, 2.6f);
		_currentPosition = new Vector2 (xpos, ypos);
		_transform.position = _currentPosition;
	}
}
