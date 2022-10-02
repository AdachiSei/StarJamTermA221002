using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : ItemBase,IEffect
{
    public int Score => _score;

    [SerializeField]
    [Header("�X�R�A�̓_��")]
    int _score = 500;

    public void IEffect()
    {
        Effect();
    }

    protected override void Effect()
    {
        ScoreManager.Instance.AddScore(_score);
    }
}
