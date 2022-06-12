using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("howtoplay");
    }
    public void WhoMadeThisGame()
    {
        SceneManager.LoadScene("whomadethisgame");
    }
    public void BacktoFirst()
    {
        SceneManager.LoadScene("Menu");
    }
}
