using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIns : MonoBehaviour
{
    [SerializeField] GameObject _waterBullet;
    [SerializeField] float _bulletCoolTime = 1f;
    bool _isbullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && !_isbullet)
        {
            Instantiate(_waterBullet, gameObject.transform.position, Quaternion.identity);
            _isbullet = true;
            StartCoroutine(BulletCoolTime());
        }
    }

    IEnumerator BulletCoolTime()
    {

        yield return new WaitForSeconds(_bulletCoolTime);
        _isbullet = false;
    }
}
