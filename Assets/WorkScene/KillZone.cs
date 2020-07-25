using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
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
        //if(other.gameObject.GetComponent<bullet>())
        {
            Destroy(other.gameObject);
            return;
        }

        //if (other.gameObject.GetComponent<fix>())
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            return;
        }
    }
}
