using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practicescript : MonoBehaviour
{
    private int myNumber = 3;
    // Start is called before the first frame update
    void Start()
    {
        myNumber = myNumber * 3;
        Debug.Log("This is in start");
        Debug.Log("I want " + myNumber + " Cookies");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("This is in Update");
       
    }
}
