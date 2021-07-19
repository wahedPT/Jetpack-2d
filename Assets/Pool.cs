 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PoolItems
{
    public GameObject prefab;
    public int amount;
}
public class Pool : MonoBehaviour
{
    public static Pool instance;
    public List<PoolItems> items;
    public List<GameObject> poolObjects;

    private void Awake()
    {
       
        
            instance = this;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        poolObjects = new List<GameObject>();
        foreach(PoolItems objectitems in items )
        {
            for(int i=0;i<objectitems.amount;i++)
            {
                GameObject Coinref= Instantiate(objectitems.prefab);
                Coinref.SetActive(false);
                poolObjects.Add(Coinref);
            }
        }
    }
    public GameObject Get(string tag)
    {
        for (int i = 0; i < poolObjects.Count; i++)
        {
            if(!poolObjects[i].activeInHierarchy&&poolObjects[i].tag==tag)
            {
                return poolObjects[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
