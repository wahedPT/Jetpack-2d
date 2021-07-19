using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    //game states
    public static bool gameOver;
    public GameObject GameOverPanel;
    public GameObject ScoreObj;
    public SaveData savedata;




    // Start is called before the first frame update
    void Start()
    {
        
        gameOver = false;
        
    }
    public void GameOver()
    {
        gameOver = true;
        ScoreObj.SetActive(false);
        GameOverPanel.SetActive(true);
        savedata.SetData();
        savedata.GetData();
    }

    public void onokButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
    public void OnmenuClick()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        //if (gameOver)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //    }
           
        //}
    }
}
