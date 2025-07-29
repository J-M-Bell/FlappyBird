using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// BirdScript is a MonoBehaviour that controls the bird's movement in a 2D game.
/// 
/// </author> JM Bell
/// </version> 07/28/2025
/// </summary>
public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the space key is pressed
        // If it is, apply an upward force to the bird's Rigidbody2D
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }


    }
}
