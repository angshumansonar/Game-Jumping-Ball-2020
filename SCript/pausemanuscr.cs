using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemanuscr : MonoBehaviour
{
    public GameObject resumepanal;

    private void Start()
    {
        resumepanal.SetActive(false);
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        resumepanal.SetActive(false);
    }

    public void Back()
    {
        SceneManager.LoadScene("menu");
    }
}
