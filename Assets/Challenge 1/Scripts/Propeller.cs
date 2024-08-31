using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float propellerSpeed = 500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //making the propeller spin
       transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
