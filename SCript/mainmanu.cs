using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
   public void Playgame()
    {
        SceneManager.LoadScene("SampleScene");
        scorescriiipt.scoreevalue = 0;
        pointscript.pointvalue = 0;
        Time.timeScale = 1f;
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
