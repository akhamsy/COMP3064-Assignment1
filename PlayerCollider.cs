using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : PlayerCollider.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/27/2016
 * Date Last Modified : 10/27/2016
 * Description		  : Controls player collisions
 * Revision			  : 0.1
 * */

public class PlayerCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "star") 
        {
			Debug.Log ("Collision with " + other.gameObject.tag);
            Player.Instance.Points += 1;
            StarController star = other.gameObject.GetComponent<StarController>();
            AudioSource asrc =
                other.gameObject.GetComponent<AudioSource>();
            if (asrc != null)
            {
                asrc.Play();
            }

            if (star != null)
            {
                star.Reset();
            }
		}

		if (other.gameObject.tag == "enemy") 
        {
			Debug.Log ("Collision with " + other.gameObject.tag);
            Player.Instance.Health -= 1;
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            AudioSource asrc = other.gameObject.GetComponent<AudioSource>();
            if (asrc != null)
            {
                asrc.Play();
            }

            if (enemy != null)
            {
                enemy.Reset();
            }
		}




	}
		
}
