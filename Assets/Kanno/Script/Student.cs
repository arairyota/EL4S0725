using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    static private int Score = 0;

    static private bool flag_ = true;

    [Header("スコアが減るスパン")]
    [SerializeField]
    static private float span_ = 3.0f;

    static private float time_ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// 最初に呼ばれるupdate
    /// /// </summary>
    private void FixedUpdate()
    {
        if(flag_)
        {
            flag_ = false;

            time_ += UnityEngine.Time.deltaTime;

            if (span_ <= time_)
            {
                time_ = 0.0f;

                Score--;

                Debug.Log("スコア : " + Score.ToString());
            }
        }
    }

    private void LateUpdate()
    {
        flag_ = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        //var bullet = other.GetComponent<bullet>();

        //if(null != bullet)
        {
            Score++;
            Destroy(other);
        }
    }
}
