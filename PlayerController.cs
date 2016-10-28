using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : PlayerController.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/27/2016
 * Date Last Modified : 10/27/2016
 * Description		  : Controls player sprite
 * Revision			  : 0.1
 * */

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.08f;

	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;

	//Initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {

		_playerInput = Input.GetAxis ("Vertical");
		_currentPosition = _transform.position;

		//move up
		if (_playerInput > 0) {
			_currentPosition += new Vector2 (0, speed);
		}
		//move down
		if (_playerInput < 0) {
			_currentPosition -= new Vector2 (0, speed);
		}
		//player bounds
		if (_currentPosition.y < -2.93f) {
			_currentPosition.y = -2.93f;
		}
		if (_currentPosition.y > 2.6f) {
			_currentPosition.y = 2.6f;
		}


		_transform.position = _currentPosition;
	}
		
}
