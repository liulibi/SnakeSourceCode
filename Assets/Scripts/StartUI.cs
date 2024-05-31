using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{
    [SerializeField] private UIMananger uiMananger;
    [SerializeField] private Button startButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button endButton;

    private void Awake()
    {
        uiMananger = FindObjectOfType<UIMananger>();
    }

    public void StartGame()
    {
        uiMananger.isGaming = true;
        uiMananger.CloseAllUI();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSettingsUI()
    {
        uiMananger.OpenSettingsUI();
    }
}
