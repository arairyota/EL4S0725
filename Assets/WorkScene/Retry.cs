using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Retry : MonoBehaviour
{
    //ゲームシーン名
    [SerializeField]
    private string m_TitleSceneName;

    // Update is called once per frame
    void Update()
    {
        //遷移処理
        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(m_TitleSceneName);
    }
}
