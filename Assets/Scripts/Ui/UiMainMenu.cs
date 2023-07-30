using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour
{
    [SerializeField] Button mainMenu;

   

   

    void Start()
    {
        mainMenu.onClick.AddListener(StartMap);
    }

    public void StartMap()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Map);


    }

}
