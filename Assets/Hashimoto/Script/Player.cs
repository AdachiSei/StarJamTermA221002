using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Header("�X�s�[�h")]
    float _speed = 0f;

    Rigidbody2D _rb2d;// ����

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        _rb2d.velocity = (new Vector2(x, y) * _speed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IEffect effect))
        {
            effect.IEffect();
        }
    }

    private void OnDisable()
    {
        SoundManager.Instance.StopBGM();
        SoundManager.Instance.PlaySFX(SFXType.Death);
    }
}
