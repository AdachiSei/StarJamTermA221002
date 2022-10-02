using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シングルトンパターンを実装したい時に継承するジェネリックな基底クラス
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    [Header("シーンが移動しても保持するか")]
    bool _isDontDestroy;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;

                if (_instance == null)
                {
                    Debug.LogError($"{typeof(T)}をアタッチしているGameObjectがありません");
                }
            }

            return _instance;
        }
    }

    static T _instance;

    virtual protected void Awake()
    {
        if (_isDontDestroy) DontDestroyOnLoad(this);

        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if (_instance == null)
        {
            _instance = this as T;
            return true;
        }
        else if (_instance == this)
        {
            return true;
        }
        else
        {
            Destroy(this);
            return false;
        }
    }
}
