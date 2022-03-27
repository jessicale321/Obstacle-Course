using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    //[SerializeField] float xValue = 0f; // f = float
    //[SerializeField] float yValue = 0.0f; // shows up on GUI
    // changing in Inspector does not change in script

    //[SerializeField] float zValue = 0f;


    // Start is called before the first frame update
    void Start()
    {
        // adds 1, 0, 0 to object, is NOT a position setter
        //transform.Translate(1, 0, 0); // accessing the transform of object (in this case, player)
        PrintInstruction();
    }
    

    // Update is called once per frame, 60x per second
    void Update() // amt of calls to update depends on the computer - better computer calls Update more times in a sec
    {


        MovePlayer();

    }

    void PrintInstruction() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your characters with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer() 
    {
        //transform.Translate(xValue,yValue,zValue); 

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // Time.deltaTime tells the duration of a frame
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // Time.deltaTime makes the playerMovement framerate independent
    
        // access input manager
        transform.Translate(xValue, 0, zValue);
    }
}
