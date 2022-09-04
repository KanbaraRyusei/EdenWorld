using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : SingletonMonoBehaviour<SceneLoder>
{
    protected override void Awake()
    {
        base.Awake();
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadSceneAsync(name);
    }
}
