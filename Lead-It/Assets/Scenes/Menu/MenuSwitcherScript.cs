using UnityEngine;
using System.Collections;

public class MenuSwitcherScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SetupGameMenu;
    public GameObject SettingsMenu;
    public GameObject CreditsMenu;

    public void ShowSetupGame()
    {
        Application.LoadLevel(2);
    }

    public void ShowSettings()
    {
        NGUITools.SetActive(MainMenu, false);
    }

    public void ShowCredits()
    {
        NGUITools.SetActive(MainMenu, false);
    }
}
