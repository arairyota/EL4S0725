using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JyugyouWave : Bullet
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Tagで判定
        if (collision.transform.tag == "Syougaibutu")
        {
            Destroy(gameObject);
        }

        if(collision.transform.tag == "Student")
        {
            //なんかする
        }
    }
}
