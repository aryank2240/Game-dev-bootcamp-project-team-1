using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restriction : MonoBehaviour
{    
    public Rigidbody2D rb;
    public Transform player;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(Game_end.player_x + 0.6f * i , player.position.y);
        rb.MovePosition(pos);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(Game_end.player_x + 0.6f * i , player.position.y);
        rb.MovePosition(pos);
    }
}
