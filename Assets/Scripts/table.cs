using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class table : MonoBehaviour {

float invokeWaitTime = 5f;
public Text textIme1;
public Text textIme2;
public Text textIme3;
public Text textScore1;
public Text textScore2;
public Text textScore3;
public Text num1;
public Text num2;
public Text num3;
public Text scoreNow;
	// Use this for initialization
	void Start () {
		scoreNow.text = PlayerPrefs.GetInt("scoreBest").ToString();
		// textIme.text = PlayerPrefs.GetString("username");
		// textScore.text = PlayerPrefs.GetInt("scoreBest").ToString();
		if(PlayerPrefs.GetInt("scoreBest") > PlayerPrefs.GetInt("1st")){
			PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("2nd"));
			PlayerPrefs.SetInt("2nd", PlayerPrefs.GetInt("1st"));
			PlayerPrefs.SetInt("1st", PlayerPrefs.GetInt("scoreBest"));
			PlayerPrefs.SetString("name3",PlayerPrefs.GetString("name2"));
			PlayerPrefs.SetString("name2",PlayerPrefs.GetString("name1"));
			PlayerPrefs.SetString("name1",PlayerPrefs.GetString("username"));
		}
		if(PlayerPrefs.GetInt("scoreBest")<PlayerPrefs.GetInt("1st") && PlayerPrefs.GetInt("scoreBest")>PlayerPrefs.GetInt("2nd")){
			PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("2nd"));
			PlayerPrefs.SetInt("2nd", PlayerPrefs.GetInt("scoreBest"));
			PlayerPrefs.SetString("name3",PlayerPrefs.GetString("name2"));
			PlayerPrefs.SetString("name1",PlayerPrefs.GetString("username"));
		}
		if(PlayerPrefs.GetInt("scoreBest")<PlayerPrefs.GetInt("2nd") && PlayerPrefs.GetInt("scoreBest")>PlayerPrefs.GetInt("3rd")){
			PlayerPrefs.SetInt("3rd",PlayerPrefs.GetInt("scoreBest"));
			PlayerPrefs.SetString("name3",PlayerPrefs.GetString("username"));
		}

		textScore1.text = PlayerPrefs.GetInt("1st").ToString();
		textScore2.text = PlayerPrefs.GetInt("2nd").ToString();
		textScore3.text = PlayerPrefs.GetInt("3rd").ToString();
		textIme1.text = PlayerPrefs.GetString("name1");
		textIme2.text = PlayerPrefs.GetString("name2");
		textIme3.text = PlayerPrefs.GetString("name3");
		num1.text = "1";
		num2.text = "2";
		num3.text = "3";
	}
	
	// Update is called once per frame
	void Update () {

		Invoke("LoadFirstLevel", invokeWaitTime);
	}
	private void LoadFirstLevel() {
        SceneManager.LoadScene(1);
    }
}
