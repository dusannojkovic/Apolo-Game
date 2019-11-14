using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginUser : MonoBehaviour {

public GameObject name;
public string Username;

    void Update(){
        Username = name.GetComponent<InputField>().text;
    }
	public void PlayGame()
    {
        PlayerPrefs.SetString("username", Username);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
   
}
