using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    GameObject pauseMenu;
    bool paused;
    // Use this for initialization
    void Start()
    {
        paused = false;
        pauseMenu = GameObject.Find("PauseMenu");

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            paused = !paused;
        }
        if(paused){
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if(!paused){
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume(){

            paused = false;

    }
    public void Exit(){
        Application.Quit();
    }
}