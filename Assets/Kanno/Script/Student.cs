using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    static private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //var teacher = other.GetComponent<>();

        //if(null != teacher)
        {
            Score++;
            Destroy(other);
        }
    }
}
