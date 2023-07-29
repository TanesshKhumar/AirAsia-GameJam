using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class UiMap : MonoBehaviour
{
    [SerializeField] Button Malaysia;
    [SerializeField] Button Singapore;
    [SerializeField] Button Indonesia;


    void Start()
    {
        Malaysia.onClick.AddListener(StartLevelMalaysia);
        Singapore.onClick.AddListener(StartLevelSingapore);
        Indonesia.onClick.AddListener(StartLevelIndonesia);
    }

    private void StartLevelMalaysia()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Malaysia01);
    }

    private void StartLevelSingapore()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Singapore02);
    }

    private void StartLevelIndonesia()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Indonesia03);
    }

}
