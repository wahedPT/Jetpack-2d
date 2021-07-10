using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerM : MonoBehaviour
{
   // public float speed;
    Rigidbody2D rb;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (gameOver)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Game");
            }
            return;
        }
      if(Input.GetKey(KeyCode.Space))
      {
            rb.AddForce(new Vector2(0, 50));
      }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
           // rb.AddForce(new Vector2(0, -speed));
            rb.velocity *= 0.25f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "Enemy")
        {
            gameOver = true;
            rb.isKinematic = true;
           // Destroy(this.gameObject);
        }
    }
}
