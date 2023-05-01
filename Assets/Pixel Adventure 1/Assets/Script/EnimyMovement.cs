using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnimyMovement : MonoBehaviour
{
    private bool nend;
    public Transform t;
  
    public int Sx, Sy,Ex, Ey;
    // Start is called before the first frame update
    void Start()
    {
        nend = true;
        t.GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
          if(nend)
        {
            t.position += new Vector3(0.01f, 0, 0);
            
            if (t.position.x >= Ex && t.position.y ==Ey)
            {
                nend=false;
            }

        }
        else
        {
            t.position += new Vector3(-0.01f, 0, 0);
            if (t.position.x <= Sx && t.position.y == Sy)
            {
                nend = true;
            }
        }


    }
}
