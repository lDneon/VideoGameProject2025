using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public void GamePlay()
    {
        SceneManager.LoadScene("Gameplay");
        Debug.Log("Button clicked!");
    }
    public void GameQuit()
    {
        Application.Quit();
    }
   
}
