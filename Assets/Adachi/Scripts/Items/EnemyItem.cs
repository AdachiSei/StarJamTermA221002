using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyItem : ItemBase
{
    [SerializeField]
    [Header("���U���g�V�[���ɍs���܂ł̎���")]
    int _nextSceneSeconds = 1000;

    const string SCENE_NAME = "ResultScene";

    protected override async void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            collision.gameObject.SetActive(false);
            await Task.Delay(_nextSceneSeconds);
            //SceneLoader��ǂݏo��
            SceneLoader.Instance.SceneLoad(SCENE_NAME);
        }
        base.OnTriggerEnter2D(collision);
    }
}
