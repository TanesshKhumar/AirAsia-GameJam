using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System;

public class UiMap : MonoBehaviour
{
    [Header("Set Buttons Here")]
    [SerializeField] Button MainMenu;
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
    

    public GameObject[] uiElements;
    private GameObject activeUI;
    GameObject previouslyActiveUI;

    void Start()
    {
        SetActiveUI(uiElements[i]);

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
        MainMenu.onClick.AddListener(ReturnToMainMenu);
    }

    private void ReturnToMainMenu()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.MainMenu);
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

    public void SetActiveUI(GameObject uiElement)
    {
        // Deactivate the previously active UI (if any)
        if (previouslyActiveUI != null)
            previouslyActiveUI.SetActive(false);

        // Set the new active UI element and activate it
        uiElement.SetActive(true);

        // Update the previouslyActiveUI variable with the current UI element
        previouslyActiveUI = uiElement;
    }

    int i = 0;

    public void OnButton1Next()
    {
        // Increment i and ensure it stays within the valid range
        i = Mathf.Clamp(i + 1, 0, uiElements.Length - 1);

        // Call SetActiveUI method and pass the reference to the UI element you want to activate
        SetActiveUI(uiElements[i]);

        
    }

    public void OnButton2Prev()
    {
        // Decrement i and ensure it stays within the valid range
        i = Mathf.Clamp(i - 1, 0, uiElements.Length - 1);

        // Call SetActiveUI method and pass the reference to the UI element you want to activate
        SetActiveUI(uiElements[i]);
    }
}
