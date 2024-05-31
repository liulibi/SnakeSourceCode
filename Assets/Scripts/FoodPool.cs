using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPool : MonoBehaviour
{
    public GameObject foodPrefab;
    public int maxFoodCount = 5;
    public int currentFoodCount;

    public float spawnInterval = 1f;
    public Collider2D gridArea;
    private Snake snake;


    private void Start()
    {
        currentFoodCount = 0;
        snake = FindObjectOfType<Snake>();
        StartCoroutine(SpawnFoodRoutine());
    }

    private IEnumerator<WaitForSeconds> SpawnFoodRoutine()
    {
            while (true)
            {
                while (currentFoodCount >= maxFoodCount)
                {
                    yield return new WaitForSeconds(spawnInterval *2);

                }

                while (currentFoodCount < maxFoodCount)
                {
                    currentFoodCount++;
                    SpawnFood();
                    yield return new WaitForSeconds(spawnInterval);
                }
            }
    }

    private void SpawnFood()
    {
        ObjectPoolManager.SpawnObject(foodPrefab, RandomizePosition(), Quaternion.identity, ObjectPoolManager.PoolType.GameObject);
    }


    public Vector2 RandomizePosition()
    {
        Bounds bounds = gridArea.bounds;

        // Pick a random position inside the bounds
        // Round the values to ensure it aligns with the grid
        int x = Mathf.RoundToInt(Random.Range(bounds.min.x, bounds.max.x));
        int y = Mathf.RoundToInt(Random.Range(bounds.min.y, bounds.max.y));

        // Prevent the food from spawning on the snake
        while (snake.Occupies(x, y))
        {
            x++;

            if (x > bounds.max.x)
            {
                x = Mathf.RoundToInt(bounds.min.x);
                y++;

                if (y > bounds.max.y)
                {
                    y = Mathf.RoundToInt(bounds.min.y);
                }
            }
        }

        return new Vector2(x, y);
    }


    public void EatFood()
    {
        if (currentFoodCount > 0)
            currentFoodCount--;
    }
}
