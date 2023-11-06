using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float Y = -4.8528f;
    public bool is_hill;
    
    private Rigidbody2D rb;
    public bool is_portal = false;
    public bool is_mid = false;
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
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed;

        rb.velocity = movement;
        
        if(Game_end.game_over == 0) 
        {

            if(Game_end.active_portal == true)
            {
                moveSpeed = 10;
            }
            else
            {
                moveSpeed = 5;
            }
        
        
        
            if(rb.position.x < -shift-1)
            {
                if(is_hill == true){
                    Game_end.score += 1;
                }
                if(is_portal == true && Game_end.active_portal == false)
                {
                    int x = Game_end.rnd.Next(11);
                    if(x<Game_end.portal_probability)
                    {
                        Vector2 post = new Vector2(rb.position.x + shift * 2.5f , -3 + Game_end.rnd.Next(3));
                        rb.MovePosition(post);
                    }
                    else
                    {
                        Vector2 post = new Vector2(rb.position.x + shift * 2.5f , 30);
                        rb.MovePosition(post);

                    }
                }
                else if(is_portal == true){
                        Vector2 post = new Vector2(rb.position.x + shift * 2.5f , 30);
                        rb.MovePosition(post);

                    }
                else if(is_mid == true){
                    int x = Game_end.rnd.Next(11);
                    if(x <5){
                        int y= Game_end.rnd.Next(5);
                        Vector2 pos1 = new Vector2(rb.position.x + shift * 2.5f , Y+y);
                        rb.MovePosition(pos1);
                    }
                    else{
                        Vector2 pos2 = new Vector2(rb.position.x + shift * 2.5f , 5-Y);
                        rb.MovePosition(pos2);
                    }
                }
                else{
                    Vector2 pos = new Vector2(rb.position.x + shift * 2.5f , Y);
                    rb.MovePosition(pos);
                }
            }
            

        
    
        }
    }
}