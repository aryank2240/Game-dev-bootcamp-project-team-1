using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_check : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
    
        if(collision.gameObject.CompareTag("Player"))// 
        {
            Game_end.game_over = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
