using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 * File Name	 	  : HUDController.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/30/2016
 * Date Last Modified : 10/30/2016
 * Description		  : Controls HUD
 * Revision			  : 1.0
 * */

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text points = null;
	[SerializeField]
	Text health = null;
    [SerializeField]
    Button restartBtn = null;
    [SerializeField]
    RawImage gameOverLabel = null;
    [SerializeField]
    GameObject player = null;
    [SerializeField]
    GameObject star = null;
    [SerializeField]
    GameObject enemy = null;
    [SerializeField]
    RawImage startLabel = null;

    //Initialization, hide all ui elements except the start label and play button
	void Start () {

        player.SetActive(false);
        star.SetActive(false);
        enemy.SetActive(false);
        points.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        gameOverLabel.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(true);
        startLabel.gameObject.SetActive(true);
		Player.Instance.hud = this;

	}
	
	public void UpdatePoints(){
		points.text = "Points: " + Player.Instance.Points; //Update player points to HUD
	}

	public void UpdateHealth(){
		health.text = "Health: " + Player.Instance.Health; //Update player hp to HUD
	}

    public void GameOver() { //Hide all game elements and display game over label and play button

        player.SetActive(false);
        star.SetActive(false);
        enemy.SetActive(false);
        points.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        gameOverLabel.gameObject.SetActive(true);
        restartBtn.gameObject.SetActive(true);
        startLabel.gameObject.SetActive(false);

    }

    public void Restart() { //Restart game

        startLabel.gameObject.SetActive(false);
        points.gameObject.SetActive(true);
        health.gameObject.SetActive(true);
        star.SetActive(true);
        enemy.SetActive(true);
        Player.Instance.Points = 0;
        Player.Instance.Health = 5;
        points.text = "Points: 0";
        health.text = "Health: 5";
        player.SetActive(true);
        gameOverLabel.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(false);

    }
}
