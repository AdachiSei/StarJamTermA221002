using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    public int Score => _score;

    [SerializeField]
    [Header("�X�R�A�e�L�X�g")]
    Text _scoreText;

    int _score;

    public int AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString();
        return _score;
    }

    public int ResetScore => _score = 0;
}
