using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CityCollider : MonoBehaviour
{
    // This function is called when another object enters the collider
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is a specific object, e.g., a player
        if (other.CompareTag("Player"))
        {
            // Implement your logic here, for example:
            Debug.Log("Player has entered the city area");
            // You can also trigger other actions, like starting a mission
        }
    }

    // This function is called when another object exits the collider
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has left the city area");
            // Additional logic when the player leaves the area
        }
    }
}

