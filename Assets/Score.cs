using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text t;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Score : "  +  Game_end.score.ToString();
    }
}
