using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle2 : MonoBehaviour
{
    
    public float speed=5f;
    private Rigidbody2D rb;
    private Vector3 startpostion;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startpostion = transform.position;
    }

    
    void Update()
    {
       if(Input.GetKey("i"))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        else if (Input.GetKey("k"))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
   
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startpostion;
    }
}
