using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    const string SCENE_NAME_GAMECLEAR = "GameClear";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            SceneLoader.Instance.SceneLoad(SCENE_NAME_GAMECLEAR);
        }
    }
}
