using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public PlayerM player;
    public Gamemanager GetGamemanager;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.gameOver == false)
        {
            transform.Translate(new Vector2(5     , 0) * Time.deltaTime);
        }

           
        


    }
}
