using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Retry : MonoBehaviour
{
    //タイトルシーン名
    [SerializeField]
    private string m_TitleSceneName;

    [SerializeField]
    AudioSource m_ClickSound;

    // Update is called once per frame
    void Update()
    {
        //遷移処理
        if (Input.GetKeyDown(KeyCode.Return))
        {
            m_ClickSound.PlayOneShot(m_ClickSound.clip);

            StartCoroutine(ToNextScene());
        }

    }

    IEnumerator ToNextScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(m_TitleSceneName);
    }
}
