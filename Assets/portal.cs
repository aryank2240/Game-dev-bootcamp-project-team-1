using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class portal : MonoBehaviour
{
    public Transform player; // Assign the player object to this field in the Unity Inspector.
    public int X;
    public int Y;
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Replace "Player" with the tag of the player object.
        {
            MovePlayerToNewPosition();
            Debug.Log("Teleported");
        }
    }

    void MovePlayerToNewPosition()
    {
        Vector3 newPosition = new Vector3(X, Y, 0); // Set the desired new position.
        player.position = newPosition;
        Game_end.player_x = X;
    }
}