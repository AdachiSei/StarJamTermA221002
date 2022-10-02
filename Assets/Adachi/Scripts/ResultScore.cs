using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField]
    [Header("スコアテキスト")]
    Text _scoreText;

    private void Awake()
    {
        _scoreText.text = ScoreManager.Instance.Score.ToString();
    }
}
