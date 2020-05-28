using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointscript : MonoBehaviour
{
    public static int pointvalue = 00;
    public Text pointt;
    // Start is called before the first frame update
    void Start()
    {
        pointt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pointt.text = pointvalue.ToString();
    }
}
