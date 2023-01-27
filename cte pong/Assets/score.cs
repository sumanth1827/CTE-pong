using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text p1score,p2score;
    private int p1 = 0, p2 = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scorep1()
    {
        p1++;
        p1score.text = p1.ToString();
    }
    public void scorep2()
    {
        p2++;
        p2score.text = p2.ToString();

    }
}
