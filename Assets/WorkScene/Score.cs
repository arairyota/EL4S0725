using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text Texture;

    // Start is called before the first frame update
    void Start()
    {
        SetScore(Student.GetScore());
    }
    
    public void SetScore(int s)
    {
        Texture.text = s.ToString();
    }
}
