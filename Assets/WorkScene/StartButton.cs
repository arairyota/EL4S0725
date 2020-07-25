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
    private Text Texture;

    [SerializeField]
    AudioSource m_ClickSound;

    // Update is called once per frame
    void Update()
    {
        //遷移処理
        if(Input.GetKeyDown(KeyCode.Return))
        {
            m_ClickSound.PlayOneShot(m_ClickSound.clip);

            StartCoroutine(ToNextScene());
        }


        Color c = Texture.color;
        c.a = Mathf.Sin(Time.time * 3);
        Texture.color = c;
    }

    IEnumerator ToNextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(m_GameSceneName);
    }
}
