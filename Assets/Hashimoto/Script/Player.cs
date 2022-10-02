using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Header("スピード")]
    float _speed = 0f;


    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= _speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += _speed;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            position.y += _speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.y -= _speed;
        }

        transform.position = position;
    }
}
