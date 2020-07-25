using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    [Header("テキスト")]
    [SerializeField]
    private Text text_ = null;

    [SerializeField]
    private string m_ResultScene;

    private float countTime_ = 0.0f;
    [SerializeField]
    private float MaxTime;

    // Start is called before the first frame update
    void Start()
    {
        countTime_ = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        countTime_ -= UnityEngine.Time.deltaTime; //スタートしてからの秒数を格納

        text_.text = countTime_.ToString("F1"); //小数2桁にして表示

        if(countTime_ <= 0)
        {
            SceneManager.LoadScene(m_ResultScene);
        }
    }
}
