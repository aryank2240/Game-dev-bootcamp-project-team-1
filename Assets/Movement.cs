using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    float moveSpeed = 5f;
    float shift = 8f; //half width of the screen = 4 x width of traps
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Game_end.game_over == 0)
        {


        float horizontalInput = 0f;
        float verticalInput = 0f;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            if(rb.position.x > +shift+1){
            Vector2 pos = new Vector2(rb.position.x - shift * 2.5f, rb.position.y);
            rb.MovePosition(pos);
        }
            horizontalInput = 1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            if(rb.position.x < -shift-1){
            Vector2 pos = new Vector2(rb.position.x + shift * 2.5f , rb.position.y);
            rb.MovePosition(pos);
        }
            horizontalInput = -1f;
        }

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed;

        rb.velocity = movement;

        

        }
    }
}
