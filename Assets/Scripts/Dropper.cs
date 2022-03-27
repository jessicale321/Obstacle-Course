using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField]float waitTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>(); // caching a reference - storing frequently used data in memory to make it easily accessible
        rigidBody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Time elapsed: " + Time.time);
        if (Time.time > waitTime) {
            //Debug.Log("Passed wait time");
            
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
