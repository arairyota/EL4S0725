using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    /// <summary>
    /// 飛ばす線の参照
    /// </summary>
    [Header("飛ばす線")]
    [SerializeField] GameObject Line_ = null;

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
        _firePoint = GetComponent<FirePoint>();

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
            _fireRateCount = 0.0f;

            foreach (Transform child in Line_.transform)
            {
                if (child.GetComponent<KillZone>())
                {
                    //弾発射
                    _firePoint.Fire(transform.position, 1);
                    return;
                }
            }

            {
                //弾発射
                _firePoint.Fire(transform.position, 0);
            }

            

            
        }

        _fireRateCount += UnityEngine.Time.deltaTime;
    }
}
