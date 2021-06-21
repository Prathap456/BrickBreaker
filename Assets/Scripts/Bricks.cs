using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bricks : MonoBehaviour
{
    SpriteRenderer sprite;
    public int health = 2;
    //public int count = 8;
    //public GameObject[] brick;
    //public int brickCount;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        //brick = new GameObject[GameObject.FindGameObjectsWithTag("Brick").Length];
        //print(brick.Length);
        //brickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ball")
        {
            health--;
            //brickCount--;
            sprite.color = new Color(1, 0.4f, 0, 1);

        }
       
        if(health == 1)
        {
            
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
       //if(brickCount == 0)
       // {
       //     SceneManager.LoadScene(1);
       // }
    }
    }

