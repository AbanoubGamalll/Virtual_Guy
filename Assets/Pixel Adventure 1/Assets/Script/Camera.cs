using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(8, 2, -10);
    public float campos = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 real=Vector3.Lerp(transform.position, (player.position + offset) * 0.5f,campos);
        transform.position=real;
    }
}
