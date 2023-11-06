using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Restart",3);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void Restart(){
        Game_end.game_over=0;
        SceneManager.LoadScene(0);
    }
}
