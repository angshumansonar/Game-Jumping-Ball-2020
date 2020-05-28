using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverscript : MonoBehaviour
{
    public GameObject gameovermanu;

    private void Start()
    {
        gameovermanu.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        scorescriiipt.scoreevalue = 0;
        pointscript.pointvalue = 0;
        Time.timeScale = 1f;
    }
    public void backbt()
    {
        SceneManager.LoadScene("menu");
    }
}
