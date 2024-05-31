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
        // 游戏开始的逻辑
        Time.timeScale = 1f; // 将时间缩放设置为1，恢复游戏运行
    }

    private void StopGame()
    {
        // 游戏停止的逻辑
        Time.timeScale = 0f; // 将时间缩放设置为0，暂停游戏
    }
}
