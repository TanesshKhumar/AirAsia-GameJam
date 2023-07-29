using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class UiMap : MonoBehaviour
{
    [Header("Set Buttons Here")]
    [SerializeField] Button Malaysia;
    [SerializeField] Button Singapore;
    [SerializeField] Button Laos;
    [SerializeField] Button Brunei;
    [SerializeField] Button Cambodia;
    [SerializeField] Button Myanmar;
    [SerializeField] Button Vietnam;
    [SerializeField] Button Thailand;
    [SerializeField] Button Philippines;
    [SerializeField] Button Indonesia;


    void Start()
    {
        Malaysia.onClick.AddListener(StartLevelMalaysia);
        Singapore.onClick.AddListener(StartLevelSingapore);
        Laos.onClick.AddListener(StartLevelLaos);
        Brunei.onClick.AddListener(StartLevelBrunei);
        Cambodia.onClick.AddListener(StartLevelCambodia);
        Myanmar.onClick.AddListener(StartLevelMyanmar);
        Vietnam.onClick.AddListener(StartLevelVietnam);
        Thailand.onClick.AddListener(StartLevelThailand);
        Philippines.onClick.AddListener(StartLevelPhilippines);
        Indonesia.onClick.AddListener(StartLevelIndonesia);
    }

    private void StartLevelMalaysia()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Malaysia02);
    }

    private void StartLevelSingapore()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Singapore03);
    }

    private void StartLevelLaos()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Laos04);
    }

    private void StartLevelBrunei()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Brunei05);
    }

    private void StartLevelCambodia()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Cambodia06);
    }

    private void StartLevelMyanmar()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Myanmar07);
    }

    private void StartLevelVietnam()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Vietnam08);
    }

    private void StartLevelThailand()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Thailand09);
    }

    private void StartLevelPhilippines()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Philippines10);
    }

    private void StartLevelIndonesia()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Indonesia11);
    }

}
