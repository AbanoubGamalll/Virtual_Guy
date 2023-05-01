using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            life--;
            if (life <= 0)
            {
                Debug.Log("Game is Finish");
                //Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("life: " + life);

            }
        }
       
    }
}
