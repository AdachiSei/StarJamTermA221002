using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : SingletonMonoBehaviour<SceneLoader>
{
    protected override void Awake()
    {
        base.Awake();
        SceneManager.LoadSceneAsync("TitleScene");
    }

    /// <summary>�V�[���̃��[�h</summary>
    /// <param name="sceneName"></param>
    public void SceneLoad(string sceneName)
    {
        StartCoroutine(SceneLoadTime(sceneName));
    }

    /// <summary>���g���C�@�\</summary>
    public void ActiveSceneLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>�g����������Ȃ��֐��B</summary>
    /// <param name="sceneName"></param>
    public void ResultSceneLoad(string sceneName)
    {
        SceneManager.MoveGameObjectToScene(gameObject, SceneManager.GetActiveScene());
        StartCoroutine(SceneLoadTime(sceneName));
    }

    IEnumerator SceneLoadTime(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);
    }
}
