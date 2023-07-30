using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class UiLevel : MonoBehaviour
{


    public GameObject pausePanel;
    private bool isPaused = false;
    public SpriteRenderer plane;
    public SpriteRenderer planeChild;
    public SpriteRenderer Target;

    void Start()
    {

    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Freezes the game
            pausePanel.SetActive(true);
            plane.enabled = false;
            Target.enabled = false;
            planeChild.enabled = false;
        }
        else
        {
            Time.timeScale = 1f; // Resumes normal time flow
            pausePanel.SetActive(false);
            plane.enabled = true;
            Target.enabled = true;
            planeChild.enabled = true;
        }


    }




}

