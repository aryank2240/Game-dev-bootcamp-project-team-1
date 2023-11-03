using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 50f;
    bool OnGround = false;

    // Start is called before the first frame update
    

    void Start()
    {
        OnGround = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.position.y < -6.5){
            Game_end.game_over = 1;
        }
        if (Input.GetKey(KeyCode.Space) && OnGround )
        {
            rb.velocity = Vector2.up * speed;

            OnGround = false;
        }

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }

}
