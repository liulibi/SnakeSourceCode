using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.UI;

public class UIMananger : MonoBehaviour
{
    [SerializeField] public StartUI startUI;
    [SerializeField] public SettingsUI settingsUI;
    [SerializeField] public Text pointText;

    public bool isGaming;
    public bool isUI;

    private void Awake()
    {
        isGaming = false;
        isUI = true;
        OpenStartUI();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&!isUI)
        {
            OpenStartUI();
            isGaming = false;
        }
    }

    public void OpenStartUI()
    {
        startUI.gameObject.SetActive(true);
        settingsUI.gameObject.SetActive(false);
        pointText.gameObject.SetActive(false);
        isUI = true;
    }

    public void OpenSettingsUI()
    {
        settingsUI.gameObject.SetActive(true);
        startUI.gameObject.SetActive(false);
        pointText.gameObject.SetActive(false);
        isUI = true;
    }

    public void CloseSettingsUI()
    {
        settingsUI.gameObject.SetActive(false);
        startUI.gameObject.SetActive(true);
        pointText.gameObject.SetActive(false);
        isUI = true;
    }

    public void CloseStartUI()
    {
        startUI.gameObject.SetActive(false);
        settingsUI.gameObject.SetActive(false);
        pointText.gameObject.SetActive(true);
        isUI= false;
    }

    public void CloseAllUI()
    {
        settingsUI.gameObject.SetActive(false);
        startUI.gameObject.SetActive(false) ;
        pointText.gameObject.SetActive(true);
        isUI = false;
    }
}