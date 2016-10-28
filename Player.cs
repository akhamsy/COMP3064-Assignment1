using UnityEngine;
using System.Collections;

/*
 * File Name	 	  : Player.cs
 * Author   		  : Austin Khamsisavadty 100942529
 * Last Modified	  : 10/27/2016
 * Date Last Modified : 10/27/2016
 * Description		  : player class
 * Revision			  : 0.1
 * */

public class Player  {

	private int _points = 0;
	private int _health = 5;

	public HUDController hud;

	private static Player _instance = null;
	public static Player Instance{

		get{ 
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}
	}

	private Player(){
	}

	public int Points{
		get{ 
			return _points;
		}

		set{ 
			_points = value;
			hud.UpdatePoints();
		}
	}

	public int Health{
		get{ 
			return _health;
		}

		set{
            _health = value;
            hud.UpdateHealth();
            if (_health <= 0)
            {
                hud.GameOver();
            }
		}
	}
}
