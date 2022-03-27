using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //called when objects bump each other
    private void OnCollisionEnter(Collision other) // other = who collided 'this'
    {
        //Debug.Log("Bumped into wall");
        if (other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.magenta;
            gameObject.tag = "Hit";
        }
        
    }

}
