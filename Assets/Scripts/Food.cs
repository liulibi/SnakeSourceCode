using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Food : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 处理食物被吃掉的逻辑
            // ...
            // 将食物返回给对象池
            FoodPool foodPool = FindObjectOfType<FoodPool>();
            if (foodPool != null)
            {
                foodPool.EatFood();
                ObjectPoolManager.ReturnObjectToPool(gameObject);
            }
        }
    }
}

