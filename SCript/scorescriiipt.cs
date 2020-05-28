using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescriiipt : MonoBehaviour
{
    public static int scoreevalue = 00;
    public Text texxxt;
    
    // Start is called before the first frame update
    void Start()
    {
        texxxt = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        texxxt.text =scoreevalue.ToString();
        
    }

}
