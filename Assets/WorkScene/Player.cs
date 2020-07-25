using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //移動速度
    [SerializeField]
    private float m_MoveSpeed;

    //現在ライン位置番号
    [SerializeField]
    private int m_LineIndexNow;

    //ラインリスト
    [SerializeField]
    private GameObject[] m_Line;

    //切るオブジェクト
    [SerializeField]
    private GameObject m_KillObject;

    // Start is called before the first frame update
    void Start()
    {
        m_LineIndexNow = 0;

        Vector3 pos = transform.position;
        pos.y = m_Line[m_LineIndexNow].transform.position.y;
        pos.y -= 1.0f;
        transform.position = pos;


    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        {
            Vector3 pos = transform.position;

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                m_LineIndexNow -= 1;
                m_LineIndexNow = Mathf.Max(0, m_LineIndexNow);
                pos.y = m_Line[m_LineIndexNow].transform.position.y;

                pos.y -= 1.0f;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                m_LineIndexNow += 1;
                m_LineIndexNow = Mathf.Min(m_Line.Length - 1, m_LineIndexNow);
                pos.y = m_Line[m_LineIndexNow].transform.position.y;

                pos.y -= 1.0f;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                pos.x -= m_MoveSpeed;
                pos.x = Mathf.Max(m_Line[m_LineIndexNow].GetComponent<Line>().m_Renderer.GetPosition(1).x + 2, pos.x);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                pos.x += m_MoveSpeed;
                pos.x = Mathf.Min(m_Line[m_LineIndexNow].GetComponent<Line>().m_Renderer.GetPosition(0).x - 3, pos.x);
            }

            transform.position = pos;
        }

        //切るオブジェクト配置
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = transform.position;
            pos.x += 1;
            pos.y = m_Line[m_LineIndexNow].transform.position.y - 0.2f;
            pos.z = -1;

            var killobj = Instantiate(m_KillObject, pos, Quaternion.identity);
        }
    }
}
