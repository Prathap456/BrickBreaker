using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
    Rigidbody2D rb;
    public float ballVelocity;
    public Transform paddle;
    public float offset;
    bool start = false;
    //float Count;
    public float SuperBrickCount;
    public int brickCount;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Bricks br = FindObjectOfType<Bricks>();
        //Count = br.brick.Length;
        brickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
        SuperBrickCount = GameObject.FindGameObjectsWithTag("SuperBrick").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            
            //print("Paddle collision");
        }
        else if (collision.gameObject.tag == "Boundary")
        {
            
            //print("Boundary collision");
        }
        else if (collision.gameObject.tag == "SuperBrick")
        {
            //Destroy(collision.gameObject);
            //Count = Count - 0.5f;
            SuperBrickCount = SuperBrickCount - 0.5f;
        }
        if(collision.gameObject.tag == "Brick")
        {
            brickCount--;
        }
        //if (Count <= 0)
        //{
        //    print("Game over");
        //    SceneManager.LoadScene(1);
        //}
        if(SuperBrickCount <= 0 && brickCount<=0)
        {
            SceneManager.LoadScene(1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
            //print("Ball destroyed");
        }
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && start == false)
        {
            rb.velocity = new Vector2(0, ballVelocity);
            start = true;
           // print("Ball launched");
        }
        if (start == false)
        {
            transform.position = new Vector2(paddle.position.x, paddle.position.y + offset);
        }
    }
}
