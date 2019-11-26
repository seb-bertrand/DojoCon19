using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f; // Player movement speed
    public float backgroundWidth = 5f; // Playable area width
    private Rigidbody2D _playerRb; // Player's Rigidbody 2D

    // Start() is called when the game start
    void Start()
    {
        // TODO : Retrieve the player's Rigidbody2D
        
    }

    // FixedUpdate() is called on a regular basis but is not dependent on the FPS (Frame per second) of our game
    // FixedUpdate() is used to interract with the physics of our game
    void FixedUpdate() 
    {
        // TODO : Retrieve player's inputs (Horizontal movement)
        
        // TODO : Calculate the new player position
        
        // TODO : Move the player to the new position      
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        // TODO : Reload the level to start again
    }
}
