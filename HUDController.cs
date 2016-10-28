using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
 * File Name	 	  : HUDController.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/27/2016
 * Date Last Modified : 10/27/2016
 * Description		  : Controls HUD
 * Revision			  : 0.1
 * */

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text points = null;
	[SerializeField]
	Text health = null;
    [SerializeField]
    Button restartBtn = null;
    [SerializeField]
    Text gameOverLabel = null;
    [SerializeField]
    GameObject player = null;
    [SerializeField]
    GameObject star = null;
    [SerializeField]
    GameObject enemy = null;
    [SerializeField]
    Text highScore = null;
    [SerializeField]
    Text startLabel = null;

	void Start () {
        player.SetActive(false);
        star.SetActive(false);
        enemy.SetActive(false);
        points.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        highScore.gameObject.SetActive(false);
        gameOverLabel.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(true);
        startLabel.gameObject.SetActive(true);

		Player.Instance.hud = this;
	}
	
	public void UpdatePoints(){
		points.text = "Points: " + Player.Instance.Points;

	}

	public void UpdateHealth(){
		health.text = "Health: " + Player.Instance.Health;
	}

    public void GameOver() {
        player.SetActive(false);
        star.SetActive(false);
        enemy.SetActive(false);
        points.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        highScore.gameObject.SetActive(true);
        gameOverLabel.gameObject.SetActive(true);
        restartBtn.gameObject.SetActive(true);
        startLabel.gameObject.SetActive(false);
    }

    public void Restart() {
        startLabel.gameObject.SetActive(false);
        points.gameObject.SetActive(true);
        health.gameObject.SetActive(true);
        star.SetActive(true);
        enemy.SetActive(true);
        Player.Instance.Points = 0;
        Player.Instance.Health = 5;
        points.text = "Points: 0";
        health.text = "Health: 5";
        highScore.gameObject.SetActive(false);
        player.SetActive(true);
        gameOverLabel.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(false);
    }
}
