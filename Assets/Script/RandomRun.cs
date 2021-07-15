using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRun : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    Vector2 targetPosition;
    public float speed;


    void Start()
    {
        targetPosition = GetRandomPosition();
    }
    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
          
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
    }
    Vector2 GetRandomPosition()

    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }
}
