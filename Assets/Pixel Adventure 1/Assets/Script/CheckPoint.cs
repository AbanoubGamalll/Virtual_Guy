using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private bool check=false;
    public Transform player;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        player=GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Deth")
        {
            deth();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Point")
        {
            check = true;
            Animator.SetBool("Move", true);
            
        }

        if (collision.gameObject.tag == "Deth")
        {

            deth();
        }
    }
    void deth()
    {
        if (check)
        {
            player.position = new Vector3(-12.87f, 6.14f, 0f);
        }
        else
        {
            player.position = new Vector3(-14.22f, -4.46f, 0f);
        }
    }
}
