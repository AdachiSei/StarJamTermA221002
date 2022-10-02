using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : SingletonMonoBehaviour<SceneLoader>
{
    /// <summary>シーンのロード</summary>
    /// <param name="sceneName"></param>
    public void SceneLoad(string sceneName)
    {
        StartCoroutine(SceneLoadTime(sceneName));
    }


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
