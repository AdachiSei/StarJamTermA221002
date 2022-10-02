using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIManager : SingletonMonoBehaviour<ScoreUIManager>
{
    [SerializeField]
    [Header("スコアテキスト")]
    Text _scoreText;

    protected override void Awake()
    {
        base.Awake();
        ScoreManager.Instance.ResetScore();
    }

    public void ChangeScore(int score)
    {
        _scoreText.text = score.ToString();
    }
}
