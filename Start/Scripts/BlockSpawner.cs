using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints; // An array storing the block spawn positions
    public GameObject blockPrefab; // The 'Block' prefab
    private float timerToSpawn = 2f; // Timer variable that contains 
                                    //  the number of second to wait before spawning the next raw of blocks
    private float timeBetweenWaves = 1f; // Time between two waves of blocks

    // Update() is called every frame per second
    void Update()
    {
        // TODO : Check the timer to see if we need to spawn a wave of blocks
        
        // TODO : If so, call the SpawnBlocks method
        
        // TODO : Calculate next timer

    }

    void SpawnBlocks()
    {
        // TODO : Randomly determine an empty position on the line of blocks

        // TODO : For each spawn point ...
        
        // TODO : ... check if this is the empty position or not
        
        // TODO : If it's not, create a block on screen
                     
    }
}
