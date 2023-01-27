using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;
   
    private Rigidbody2D rb;
    private Vector3 startposition;
    public score s;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startposition = transform.position;
        Launch();
    }
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startposition;
        Launch();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "paddle")
        {
            rb.AddForce(rb.velocity * 0.5f);
        }
    }
    private void OnTriggerEnter2D(Collider2D ci)
    {
        if(ci.tag == "end1")
        {
            s.scorep1();
            
        }
        else if(ci.tag == "end2")
        {
            s.scorep2();
            
        }

    }

}
