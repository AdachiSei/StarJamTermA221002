using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    public int Score => _score;

    int _score;

    public int AddScore(int score)
    {
        _score += score;
        ScoreUIManager.Instance.ChangeScore(_score);
        return _score;
    }

    public void ResetScore()
    {
        _score = 0;
    }
}
