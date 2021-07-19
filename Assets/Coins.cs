using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    //public GameObject Coin;
    float randY;
    public float minY, maxY;
    public PlayerM player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CoinS", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.gameOver == true)
        {
            CancelInvoke("CoinS");
        }
        
    }
  

    private void CoinS()
    {

        randY = Random.Range(minY, maxY);
        GameObject CoinRef= Pool.instance.Get("Coins");
        if(CoinRef!=null)
        {
            CoinRef.transform.position = new Vector2(player.transform.position.x + 15f, randY);
            CoinRef.SetActive(true);
        }

       // obs1.transform.position = new Vector2();
       // CoinRef.transform.position = new Vector2(player.transform.position.x+15f, randY);

    }

   

}
//randY = Random.Range(minY, maxY);
//GameObject CoinRef = Instantiate(Coin);
//// obs1.transform.position = new Vector2();
//CoinRef.transform.position = new Vector2(player.transform.position.x + 15f, randY);