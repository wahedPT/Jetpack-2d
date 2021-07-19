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
    public GameObject BackG;
    public GameObject PbackG;

    public GameObject Player;


    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;

    public GameObject obstaclePrefab;
    //public GameObject obsPrefab;
    public float minObstacleY;
    public float maxObstacleY;

    public float minObstacleSpacing;
    public float maxObstacleSpacing;

    public float minObstacleScaleY;
    public float maxObstacleScaleY;

    void Start()
    {
        // InvokeRepeating("Obstacles", 2.0f, 5.0f);
        obstacle1 = GenerateObstacle(Player.transform.position.x + 10f);
        obstacle2 = GenerateObstacle(obstacle1.transform.position.x);
       	obstacle3 = GenerateObstacle(obstacle2.transform.position.x);
        obstacle4 = GenerateObstacle(obstacle3.transform.position.x);


    }
    GameObject GenerateObstacle(float referenceX)
    {
        GameObject obstacle = GameObject.Instantiate(obstaclePrefab);
        SetTransform(obstacle, referenceX);
        return obstacle;
    }

    void SetTransform(GameObject obstacle, float referenceX)
    {
        obstacle.transform.position = new Vector3(referenceX + Random.Range(minObstacleSpacing, maxObstacleSpacing), Random.Range(minObstacleY, maxObstacleY), 0);
        obstacle.transform.localScale = new Vector3(obstacle.transform.localScale.x, Random.Range(minObstacleScaleY, maxObstacleY), obstacle.transform.localScale.z);
    }
    void OnBecameInvisible()
    {
        obstacle1.SetActive(false);
        obstacle2.SetActive(false);
        obstacle3.SetActive(false);
        obstacle4.SetActive(false);
    }
    //void Obstacles()
    //{
    //    GameObject obs1 = Instantiate(obstaclePrefab);
    //    obs1.transform.position = new Vector2(Player.transform.position.x + 10f + Random.Range(5, 10), Random.Range(-4, 4));
    //}

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.gameOver == false)
        {
            if (Player.transform.position.x > floor.transform.position.x)
            {
                GameObject tempCeiling = Pceiling;
                GameObject tempfloor = Pfloor;
                GameObject tempBack = PbackG;
                Pceiling = ceiling;
                Pfloor = floor;
                PbackG = BackG;
                tempCeiling.transform.position += new Vector3(80, 0, 0);
                tempfloor.transform.position += new Vector3(80, 0, 0);
                tempBack.transform.position += new Vector3(75, 0, 0);
                ceiling = tempCeiling;
                floor = tempfloor;
                BackG = tempBack;
            }
            if (Player.transform.position.x > obstacle2.transform.position.x)
            {
                GameObject tempObstacle = obstacle1;
                obstacle1 = obstacle2;
                obstacle2 = obstacle3;
                obstacle3 = obstacle4;

                SetTransform(tempObstacle, obstacle3.transform.position.x);
                obstacle4 = tempObstacle;

            }
        }
           
    }
}
