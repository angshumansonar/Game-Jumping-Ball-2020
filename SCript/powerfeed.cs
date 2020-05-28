using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerfeed : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            
            
            Destroy(this.gameObject);
        }
      

    }
}
