using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loose : MonoBehaviour
{
    private ball b;
    private paddle1 r;
    private paddle2 j;
    // Start is called before the first frame update
    void Start()
    {
        b = GameObject.Find("ball").GetComponent<ball>();
        r = GameObject.Find("player 1").GetComponent<paddle1>();
        j = GameObject.Find("player 2").GetComponent<paddle2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D ci)
    {
       if(ci.tag == "ball")
        {
            b.Reset();
            r.Reset();
            j.Reset();
        }
       
    }
}
