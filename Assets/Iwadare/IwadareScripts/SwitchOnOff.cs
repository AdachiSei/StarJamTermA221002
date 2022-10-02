using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOff : MonoBehaviour
{
    [Tooltip("タイムラインの際消したいオブジェクト")]
    [SerializeField] GameObject _title;
    [Tooltip("タイムラインの際、表示させたいオブジェクト")]
    [SerializeField] GameObject _timelime;

    private void Start()
    {
        
    }

    /// <summary>タイムラインがスタートした時呼び出される関数。</summary>
    public void TimeLineStart()
    {
        _title.gameObject.SetActive(false);
        _timelime.gameObject.SetActive(true);
    }

    /// <summary>タイムラインが終了したとき呼び出される関数。</summary>
    public void TimeLineEnd()
    {
        _title.gameObject.SetActive(true);
        _timelime.gameObject.SetActive(false);
    }
    /// <summary>タイムラインをスキップしたいときの関数。</summary>
    public void TimeLineSkip()
    {
        _title.gameObject.SetActive(true);
        _timelime.gameObject.SetActive(false);
    }
}
