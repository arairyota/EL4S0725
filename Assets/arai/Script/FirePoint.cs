using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//弾の発射台

public class FirePoint : MonoBehaviour
{
    [Header("生成したい弾プレハブ")]
    [SerializeField] List<GameObject>   BulletList_ = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(Vector3 pos, int index)
    {
        Instantiate(BulletList_[index], pos, Quaternion.identity);
    }
}
