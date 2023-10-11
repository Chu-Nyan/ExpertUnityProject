using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneType
{
    StartScene,
    MainScene
}

public class ScenesManager : Singleton<ScenesManager>
{
    public static void LoadScene(SceneType name)
    {
        SceneManager.LoadScene((int)name);
    }
}

