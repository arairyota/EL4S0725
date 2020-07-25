using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float m_MoveSpeed;

    [SerializeField]
    private int m_LineIndexNow;

    [SerializeField]
    private GameObject[] m_Line;

    [SerializeField]
    private GameObject m_KillObject;

    // Start is called before the first frame update
    void Start()
    {
        m_LineIndexNow = 0;

        Vector3 pos = transform.position;
        pos.y = m_Line[m_LineIndexNow].transform.position.y;
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
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                m_LineIndexNow += 1;
                m_LineIndexNow = Mathf.Min(m_Line.Length - 1, m_LineIndexNow);
                pos.y = m_Line[m_LineIndexNow].transform.position.y;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                pos.x -= m_MoveSpeed;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                pos.x += m_MoveSpeed;
            }

            transform.position = pos;
        }

        //切る
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var killobj = Instantiate(m_KillObject, transform.position, Quaternion.identity);
        }
    }
}
