using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapgenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ceiling;
    public GameObject floor;
    public GameObject Pceiling;
    public GameObject Pfloor;

    public GameObject Player;

    
    public GameObject obsPrefab;
    void Start()
    {
        InvokeRepeating("Obstacles",2.0f, 5.0f);
       
        
    }

    void Obstacles()
    {
        GameObject obs1 = Instantiate(obsPrefab);
        obs1.transform.position = new Vector2(Player.transform.position.x + 10f + Random.Range(5, 10), Random.Range(-4, 4));
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x>floor.transform.position.x)
        {
            GameObject tempCeiling = Pceiling;
            GameObject tempfloor = Pfloor;
            Pceiling = ceiling;
            Pfloor = floor;
            tempCeiling.transform.position += new Vector3(80, 0,0);
            tempfloor.transform.position += new Vector3(80, 0, 0);
            ceiling = tempCeiling;
            floor = tempfloor;
        }
    }
}
