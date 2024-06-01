using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSystem : MonoBehaviour
{
    public bool gotWood = false;
    public bool foundSail = false;
    public bool gotFuel = false;
    public bool foundWrench = false;
    public bool foundHammer = false;

    private bool winTriggered = false; // Variable to track if win condition has been triggered

    // The position to teleport the player to
    public Vector3 teleportPosition = new Vector3(1, 1, 1);

    // Reference to the player GameObject
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!winTriggered && ((gotWood && foundSail) || (gotFuel && foundHammer && foundWrench)))
        {
            Debug.Log("You have all the items needed to escape the island!");
            winTriggered = true; // Set to true to prevent further triggering

            // Teleport the player to the specified position
            player.transform.position = teleportPosition;

        }
    }
}