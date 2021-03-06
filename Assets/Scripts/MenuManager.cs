﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour 
{

    // SerializeFields for assignment in the editor
    // Reference to the main menu panel
    [SerializeField] Image MainPanel;

    // Private fields
    // Are the credits visible?
    bool areCreditsVisible;

    // Start the game (switch scenes)
	public void StartButton()
    {
        SceneManager.LoadScene("Main");
    }

    // Quit the game
    public void QuitButton()
    {
        Application.Quit();
    }

    // Deactivate the main panel and show the credits
    public void CreditsButton()
    {
        if (!areCreditsVisible)
        {
            MainPanel.gameObject.SetActive(false);
            areCreditsVisible = true;
        }
    }

    // Activate the main panel and hide the credits
    public void BackButton()
    {
        if (areCreditsVisible)
        {
            MainPanel.gameObject.SetActive(true);
            areCreditsVisible = false;
        }
    }
}
