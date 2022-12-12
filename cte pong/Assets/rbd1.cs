using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbd1 : MonoBehaviour
{
    public bool p1;
    public float speed=5f;
    private Rigidbody2D rb;
    private float movement;
    private Vector3 startpostion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startpostion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(p1)
        {
            movement = Input.GetAxisRaw("Vertical");
           
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startpostion;
    }
}
