using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

    public GameObject restartPanel;
    
    private bool asLost;
    public Text timerDisplay;
    public float timer;
   
    public void GameOver()
    {
        asLost = true;
        Invoke("Delay", 1.0f);
        
    }

    void Delay()
    {
        restartPanel.SetActive(true);
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
   private void Update() 
    {
        if (asLost == false)
        {
            timerDisplay.text = timer.ToString("F0");
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }


    public void GoToGameScene()
    {
       SceneManager.LoadScene("Level1");
    }

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMenu()
    {                                        
        SceneManager.LoadScene("Menu");
    }
   
}
