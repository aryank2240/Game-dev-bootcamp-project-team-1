using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Portal : MonoBehaviour
{
    public Rigidbody2D own;
    public GameObject player;
    public GameObject portal1;
    public GameObject portal2;
    public Rigidbody2D rb;
     // Assign the player object to this field in the Unity Inspector.
    public Vector3 newPosition = new Vector3(0, 0, 0); // Set the desired new position.
    
    void Start(){
        own = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Replace "Player" with the tag of the player object.
        {
            // MovePlayerToNewPosition();
            Game_end.active_portal = true;
            player.SetActive(false);
            portal1.transform.position = new Vector3(-2, -30,10);
            Invoke("reappear",3);
        
        }
    }


    private void  reappear(){
        player.SetActive(true);
        portal2.transform.position = new Vector3(-2, 0,10);
        player.transform.position = new Vector3(-2, 0,10);
        portal2.SetActive(true);
        rb.velocity=new Vector2(0f,5f);
        
        Vector2 post = new Vector2(rb.position.x + 8 * 2.5f , -3);
        own.MovePosition(post);
        Game_end.active_portal = false;
        Invoke("Finish",1);
    }

    void Finish(){portal2.SetActive(false);}
}