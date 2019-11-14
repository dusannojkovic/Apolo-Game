using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {


	public Transform player;
	public Text scoreText;
	private double distanceNow;
	public int realDistance;
	public int positivDistance;
	public int score;


	void Start(){
		distanceNow = player.position.x;
		score = PlayerPrefs.GetInt("scoreBest");
		 Debug.Log(scoreText.text);
		 Debug.Log(PlayerPrefs.GetInt("scoreBest"));
		
	}
	// Update is called once per frame
	void Update () {

		Score();
		
	}
	void Score(){

			if(player.position.x < 0){
       		int distance = (int)(Math.Floor((Math.Abs(distanceNow)) - (Math.Abs(player.position.x))));

			this.realDistance = distance;
			score += realDistance;
			// PlayerPrefs.SetInt("scoreBest",realDistance);
			
			// PlayerPrefs.SetInt("scoreBest",realDistance);
			scoreText.text = score + "m".ToLower();

			}
			else{
			int distancePlus = (int)(Math.Floor((Math.Abs(distanceNow)) + player.position.x));
			
			this.positivDistance = distancePlus;
			score += distancePlus;
			// PlayerPrefs.SetInt("scoreBest",positivDistance);
			scoreText.text = score + "m".ToLower();
			// PlayerPrefs.SetInt("scoreBest",distancePlus);
			//scoreText.text = PlayerPrefs.GetInt("scoreBest").ToString() + "m".ToLower();
			//PlayerPrefs.SetInt("SCORE",distancePlus);
			}
			//score = positivDistance + realDistance;
			PlayerPrefs.SetInt("scoreBest",score);
			

		}
		

}


