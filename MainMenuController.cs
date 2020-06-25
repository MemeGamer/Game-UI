using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene("SampleScene");
   }

   public void EndGame()
   {
       Application.Quit();
   }

   public void Mute() {
       {
           AudioListener.pause = !AudioListener.pause;
       }
   }

   public void GameRestart()
   {
      StartCoroutine(RestartGame());
   }
   IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("SampleScene");
    }
    public void Mymenu()
   {
       SceneManager.LoadScene("Main menu");
   }
}
