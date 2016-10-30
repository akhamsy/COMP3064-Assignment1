using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : PlayerCollider.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/30/2016
 * Date Last Modified : 10/30/2016
 * Description		  : Controls player collisions
 * Revision			  : 1.0
 * */

public class PlayerCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "star") //on collision with the star
        {
            Player.Instance.Points += 1; //add 1 to the points
            StarController star = other.gameObject.GetComponent<StarController>();
            AudioSource asrc = 
                other.gameObject.GetComponent<AudioSource>();
            if (asrc != null) //play score sound
            {
                asrc.Play();
            }

            if (star != null) //reset star
            {
                star.Reset();
            }
		}

		if (other.gameObject.tag == "enemy") //on collision with the enemy
        {
            Player.Instance.Health -= 1;//remove 1 from the health
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            AudioSource asrc = other.gameObject.GetComponent<AudioSource>();
            if (asrc != null) //play hit sound
            {
                asrc.Play();
            }

            if (enemy != null) //reset enemy
            {
                enemy.Reset();
            }
		}
	}
		
}
