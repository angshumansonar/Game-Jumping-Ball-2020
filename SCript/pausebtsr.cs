using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausebtsr : MonoBehaviour
{
    public GameObject resumepanal;


    
    public void pause()
    {
     
        resumepanal.SetActive(true);
        Time.timeScale = 0f;
        
    }

}
