using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector3 startposition;
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

}
