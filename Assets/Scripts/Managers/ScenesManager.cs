using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        MainMenu,
        Map,
        Malaysia02,
        Singapore03,
        Laos04,
        Brunei05,
        Cambodia06,
        Myanmar07,
        Vietnam08,
        Thailand09,
        Philippines10,
        Indonesia11
    }

    public void LoadScene (Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }


}
