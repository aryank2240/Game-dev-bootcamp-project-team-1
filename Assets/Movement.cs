using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool is_portal = false;
    float moveSpeed = 5f;
    float shift = 8f; //half width of the screen = 4 x width of traps
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float horizontalInput = -1f;
        float verticalInput = 0f;
        if(Game_end.game_over == 0 && (is_portal && Game_end.active_portal) == false)
        {

            if(is_portal == false && Game_end.active_portal)
            {
                moveSpeed = 10;
            }
            else
            {
                moveSpeed = 5;
            }
        
        
        
            if(rb.position.x < -shift-1)
            {
                Vector2 pos = new Vector2(rb.position.x + shift * 2.5f , rb.position.y);
                rb.MovePosition(pos);
            }
            
            Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed;

            rb.velocity = movement;

        

        }
    }
}
