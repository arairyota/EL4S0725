using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    //ゲームシーン名
    [SerializeField]
    private string m_GameSceneName;

    [SerializeField]
    private Image Texture;

    // Update is called once per frame
    void Update()
    {
        //遷移処理
        if(Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(m_GameSceneName);

        Color c = Texture.color;
        c.a = Mathf.Sin(Time.time * 2);
        Texture.color = c;
    }
}
