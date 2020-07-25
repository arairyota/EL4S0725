using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("弾速度")]
    [SerializeField] float Speed_ = 1.0f;

    /// <summary>
    /// 速度代入用変数
    /// </summary>
    private Vector3 _speed = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        _speed.x = Speed_;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _speed;
    }
}
