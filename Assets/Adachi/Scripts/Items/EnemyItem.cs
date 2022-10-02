using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyItem : ItemBase
{
    [SerializeField]
    [Header("リザルトシーンに行くまでの時間")]
    int _nextSceneSeconds = 1000;

    protected override async void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        await Task.Delay(_nextSceneSeconds);
        //SceneLoaderを読み出す
    }
}
