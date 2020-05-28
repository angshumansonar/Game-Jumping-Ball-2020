using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovingforward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<Rigidbody>().velocity = new Vector3(5f, 0f, 0f);
    }
}
