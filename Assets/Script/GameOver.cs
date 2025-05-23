using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{   
    public GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
       if (GameObject.FindGameObjectWithTag("Player") == null)
       {
        gameOverPanel.SetActive(true);

       }
    }

    public void Restart()
    {
        // will be called when player clicks the restart button
        // use scene management to reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }



}
