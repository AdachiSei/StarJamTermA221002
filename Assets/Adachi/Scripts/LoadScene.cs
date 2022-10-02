using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void LoadSceneForButton(string name)
    {
        SceneLoader.Instance.SceneLoad(name);
    }
}
