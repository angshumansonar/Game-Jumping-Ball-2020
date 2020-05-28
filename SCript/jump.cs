using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    
    private Rigidbody rb;
    public ParticleSystem ps;
    public ParticleSystem ps1;
    public GameObject go;

   // public AudioClip scoread;
    public AudioSource pointad;
    public AudioSource Scoread;


    public GameObject gameover;
    
    void Start()
    {
        ps.Pause();
        ps1.Pause();
        go.SetActive(true);
        gameover.SetActive(false);

        rb = GetComponent<Rigidbody>();
       
        pointad = GetComponent<AudioSource>();
        Scoread = GetComponent<AudioSource>();

    }
    void Update()
    {

        if (Input.GetButton("Jump"))
            {
                rb.velocity = new Vector3(0f, 8f, 0f);
            
            }
        else
        {
            jumpdown();
        }
    }

   void jumpdown()
    {
        rb.velocity = new Vector3(0f, -6f, 0f);
    }
   void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("power"))
        {
            Scoread.Play();
            ps.Play();
            scorescriiipt.scoreevalue += 1;
            


        }
        else if (other.gameObject.CompareTag("point"))
        {
            
            Destroy(GameObject.FindWithTag("point"));
            pointscript.pointvalue += 1;

            pointad.Play();
            
        }
        else if (other.gameObject.CompareTag("enemy"))
        {
            ps1.Play();
            go.SetActive(false);
            gameover.SetActive(true);
            
        }

    }
}
