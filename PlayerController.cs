using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : PlayerController.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/30/2016
 * Date Last Modified : 10/30/2016
 * Description		  : Controls player sprite
 * Revision			  : 1.0
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
		if (_currentPosition.y < -2.8f) {
			_currentPosition.y = -2.8f;
		}
		if (_currentPosition.y > 2.45f) {
			_currentPosition.y = 2.45f;
		}

		_transform.position = _currentPosition;
	}
}
