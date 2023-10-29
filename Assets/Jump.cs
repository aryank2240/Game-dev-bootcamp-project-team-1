using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    bool OnGround = false;
    public float JumpForce = 10f;

    // Start is called before the first frame update
    

    void Start()
    {
        OnGround = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = rb.position;
        if(pos.x <= -7.64f){
            Game_end.game_over = -1;
        }
        //if(Game_end.game_over == 0)
       // {
        if(pos.x >=6.5f){
            Vector2 new_pos = new Vector2(pos.x-0.1f, pos.y);
            rb.MovePosition(new_pos);
        }
        if (Input.GetKey(KeyCode.Space) && OnGround )
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * JumpForce);
        }

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Hit");
            OnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Exit Hit");
            OnGround = false;
        }
    }
}
