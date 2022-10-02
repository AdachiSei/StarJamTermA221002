using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    [SerializeField]
    [Header("�w�i")]
    GameObject[] _background;

    [SerializeField]
    [Header("�X�N���[���X�s�[�h")]
    float _speed = 0.03f;

    [SerializeField]
    [Header("���̒n�_�𒴂����獶�Ƀ��[�v����")]
    float _warpPosX = 25.5f;

    bool _isPlay = true;

    const int ONE = 1;

    void Awake()
    {
        //PauseManager.Instance.OnPause += Pause;
        //PauseManager.Instance.OnRestart += Restart;
    }

    void Update()
    {
        if (_isPlay)
        {
            _background[0].gameObject.transform.position += new Vector3(_speed, 0f);
            _background[ONE].gameObject.transform.position += new Vector3(_speed, 0f);

            if (_background[0].gameObject.transform.position.x <= _warpPosX)
            {
                _background[0].gameObject.transform.position = new Vector3(-_warpPosX, 0f);
            }
            else if (_background[ONE].gameObject.transform.position.x <= _warpPosX)
            {
                _background[ONE].gameObject.transform.position = new Vector3(-_warpPosX, 0f);
            }
        }
    }

    void Pause()
    {
        _isPlay = false;
    }

    void Restart()
    {
        _isPlay = true;
    }
}
