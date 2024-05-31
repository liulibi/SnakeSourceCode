using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    private UIMananger uiManager;
    private Snake snake;
    private FoodPool pool;
    [SerializeField]private Slider snakeSpeedSlider;
    [SerializeField]private Slider maxFoodCountSlider;
    [SerializeField] private Toggle canThroughWall;

    private void Awake()
    {
        snake = FindObjectOfType<Snake>();
        pool = FindObjectOfType<FoodPool>();
        uiManager = FindObjectOfType<UIMananger>();
    }


    
    public void BackStartUI()
    {
        uiManager.OpenStartUI();
        snake.speedMultiplier = snakeSpeedSlider.value;
        pool.maxFoodCount = (int)maxFoodCountSlider.value;
        snake.moveThroughWalls = canThroughWall.isOn;
    }

}

