using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    static private int Score = 5;

    static private bool flag_ = true;

    [Header("スコアが減るスパン")]
    [SerializeField]
    static private float span_ = 3.0f;

    static private float time_ = 0.0f;

    static public int GetScore()
    {
        int score = Score;
        Score = 0;
        return score;
    }

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

                Score = Mathf.Max(Score - 1, 0);

                Debug.Log("スコア : " + Score.ToString());
            }
        }
    }

    private void LateUpdate()
    {
        flag_ = true;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        var bullet = col.gameObject.GetComponent<JyugyouWave>();

        if(null != bullet)
        {
            Score += 1;
            Destroy(col.gameObject);
        }
        else
        {
            var b = col.gameObject.GetComponent<RepairWave>();

            if (null != b)
            {
                Destroy(col.gameObject);
            }
        }
    }
}
