using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Header("スピード")]
    float _speed = 0f;

    Rigidbody2D _rb2d;

    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //_rb2d.AddForce(new Vector2(x, y), ForceMode2D.Force);
        _rb2d.velocity = (new Vector2(x, y) * _speed);
    }
}
