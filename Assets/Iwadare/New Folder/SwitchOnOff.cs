using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOff : MonoBehaviour
{
    [Tooltip("�^�C�����C���̍ۏ��������I�u�W�F�N�g")]
    [SerializeField] GameObject _title;
    [Tooltip("�^�C�����C���̍ہA�\�����������I�u�W�F�N�g")]
    [SerializeField] GameObject _timelime;

    private void Start()
    {
        
    }

    /// <summary>�^�C�����C�����X�^�[�g�������Ăяo�����֐��B</summary>
    public void TimeLineStart()
    {
        _title.gameObject.SetActive(false);
        _timelime.gameObject.SetActive(true);
    }

    /// <summary>�^�C�����C�����I�������Ƃ��Ăяo�����֐��B</summary>
    public void TimeLineEnd()
    {
        _title.gameObject.SetActive(true);
        _timelime.gameObject.SetActive(false);
    }
    /// <summary>�^�C�����C�����X�L�b�v�������Ƃ��̊֐��B</summary>
    public void TimeLineSkip()
    {
        _title.gameObject.SetActive(true);
        _timelime.gameObject.SetActive(false);
    }
}
