using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
    private int i = 0;
    [SerializeField]private int LastLvl = 9;
    [SerializeField]private GameObject WinUI;
    [SerializeField]private GameObject RetryUI;
    // Update is called once per frame
    void Update()
    {
        if(i<1){
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            if (enemies.Length == 0){
                i++;
                Time.timeScale = 0f;
                WinUI.SetActive(true);
            }
            GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
            if (player.Length == 0){
                i++;
                Time.timeScale = 0f;
                RetryUI.SetActive(true);
            }
        }
    }

    public void Retry(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel(){
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene().buildIndex == LastLvl)
            SceneManager.LoadScene(0);
        else   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
