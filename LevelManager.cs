using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public Transform mainMenu, optionsMenu, controlsMenu, copyrightMenu;

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }
    public void ControlsMenu(bool clicked)
    {
        if (clicked == true)
        {
            controlsMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(false);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            controlsMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }
    }
    public void CopyrightMenu(bool clicked)
    {
        if (clicked == true)
        {
            copyrightMenu.gameObject.SetActive(true);
            controlsMenu.gameObject.SetActive(false);
            optionsMenu.gameObject.SetActive(false);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            copyrightMenu.gameObject.SetActive(clicked);
            optionsMenu.gameObject.SetActive(true);
        }
    }

}