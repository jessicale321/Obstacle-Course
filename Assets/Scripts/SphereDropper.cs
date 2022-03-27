using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDropper : MonoBehaviour
{
    Rigidbody rigidBody;
    MeshRenderer rd;
    [SerializeField] float waitTime = 6f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rd = GetComponent<MeshRenderer>();

        rigidBody.useGravity = false;
        rd.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime) {
            rd.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
