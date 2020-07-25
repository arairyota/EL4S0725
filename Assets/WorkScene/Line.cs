using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    //ラインスタート地点オブジェクト
    [SerializeField]
    private GameObject m_StartObj;

    //ラインエンド地点オブジェクト
    [SerializeField]
    private GameObject m_EndObj;

    //ラインレンダラー
    [SerializeField]
    public LineRenderer m_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        //位置設置
        if(m_StartObj && m_EndObj)
        {
            SetLinePos(m_StartObj.transform.position, m_EndObj.transform.position);
        }
    }

    //ラインの先頭と末端位置設置
    public void SetLinePos(Vector3 pos_S, Vector3 pos_E)
    {
        m_Renderer.SetPosition(0, pos_S);
        m_Renderer.SetPosition(1, pos_E);

        Vector3 pos = Vector3.zero;
        pos.y = pos_S.y;

        transform.position = pos;
    }
}
