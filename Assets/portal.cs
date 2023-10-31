using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{
    public GameObject player;
    public GameObject portal1;
    public GameObject portal2;
    public Rigidbody2D rb;
     // Assign the player object to this field in the Unity Inspector.
    public Vector3 newPosition = new Vector3(0, 0, 0); // Set the desired new position.
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Replace "Player" with the tag of the player object.
        {
            // MovePlayerToNewPosition();
            Game_end.active_portal = true;
            Vector3 pos = portal2.transform.position;
            player.transform.position=pos;
            player.SetActive(false);
            portal1.SetActive(false);
            Invoke("reappear",1);
        
            Debug.Log("Teleported");
        }
    }


    private void  reappear(){
        player.SetActive(true);
        portal2.SetActive(true);
        rb.velocity=new Vector2(0f,5f);
        Game_end.active_portal = false;
        Invoke("Finish",1);
    }

    void Finish(){portal2.SetActive(false);}
}