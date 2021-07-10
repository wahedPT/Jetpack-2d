using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public PlayerM player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!player.gameOver)
        {
            transform.Translate(new Vector2(5, 0) * Time.deltaTime);
        }
       
    }
}
