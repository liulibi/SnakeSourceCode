using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private UIMananger uiManager;
    private bool isGameing;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIMananger>();
        isGameing = uiManager.isGaming;
    }
    private void Update()
    {
        isGameing = uiManager.isGaming;
        if (isGameing)
        {
            StartGame();
        }
        else
        {
            StopGame();
        }
    }

    private void StartGame()
    {
        // ��Ϸ��ʼ���߼�
        Time.timeScale = 1f; // ��ʱ����������Ϊ1���ָ���Ϸ����
    }

    private void StopGame()
    {
        // ��Ϸֹͣ���߼�
        Time.timeScale = 0f; // ��ʱ����������Ϊ0����ͣ��Ϸ
    }
}
