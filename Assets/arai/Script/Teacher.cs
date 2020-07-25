using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    /// <summary>
    /// 飛ばす線の参照
    /// </summary>


    /// <summary>
    /// FirePoint参照
    /// </summary>
    private FirePoint _firePoint = null;

    [Header("弾の発射間隔(秒)")]
    [SerializeField] float FireRate = 1.0f;

    /// <summary>
    /// 何秒たったか
    /// </summary>
    private float _fireRateCount = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        if(_firePoint == null)
        {
            Debug.LogError("FirePointコンポーネントが無ぇ！");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_fireRateCount > FireRate)
        {
            //弾発射
            //_firePoint.Fire()

            _fireRateCount = 0.0f;
        }

        _fireRateCount += Time.deltaTime;
    }
}
