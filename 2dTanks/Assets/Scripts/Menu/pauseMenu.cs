using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    [SerializeField]private GameObject pauseMenuUI;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void MainMenu(){
        Time.timeScale = 1f;
        isPaused = false;
        SceneManager.LoadScene(0);
    }
    public void QuitGame(){
        Debug.Log("Quit!");
        Application.Quit();
    }
}
