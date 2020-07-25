using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    static private int Score = 0;

    static private bool flag_ = true;

    [Header("スコアが減るスパン")]
    [SerializeField]
    private float span = 3.0f;

    private float time_ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        time_ = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time_ += UnityEngine.Time.deltaTime;

        if( ( span <= time_) && flag_)
        {
            time_ = 0.0f;
            flag_ = false;

            Score--;
        }
    }

    /// <summary>
    /// 最初に呼ばれるupdate
    /// /// </summary>
    private void FixedUpdate()
    {
        flag_ = true;
    }

    /// <summary>
    /// 最後に呼ばれるupdate
    /// </summary>
    private void LateUpdate()
    {
        flag_ = false;
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
