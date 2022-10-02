using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField]
    [Header("�X�R�A�e�L�X�g")]
    Text _scoreText;

    private void Awake()
    {
        _scoreText.text = ScoreManager.Instance.Score.ToString();
    }
}
