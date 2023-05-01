using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent1 : MonoBehaviour
{

    public int speed = 2;
    public Animator animator;
    public bool j;
    void Start()
    {
        j = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 3;
            Move();
        }
        else
        {
            speed = 2;
            Move();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("fall", false);
            j = true;
        }
    }
    private void  Move()
    {
        float fall = GetComponent<Rigidbody2D>().velocity.y;
        if (fall < 0 && !j)
        {
            animator.SetBool("jump", false);
            animator.SetBool("fall", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime * speed;
            GetComponent<SpriteRenderer>().flipX = false;
            animator.SetBool("run", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime * speed;
            GetComponent<SpriteRenderer>().flipX = true;
            animator.SetBool("run", true);

        }
        else
        {
            animator.SetBool("run", false);
        }

        if (Input.GetKey(KeyCode.W) && j)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * 400);
            animator.SetBool("jump", true);
            j = false;
        }
        else if (Input.GetKey(KeyCode.Space) && j)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * 400);
            animator.SetBool("jump", true);
            j = false;
        }

    }
}
