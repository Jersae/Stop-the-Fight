
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class randomwalk : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float minSpeed;
    public float maxSpeed;
    public float secondsToMaxSpeed;
    float speed;

    Vector2 targetPosition;

    void Start()
    {
        targetPosition = GetRandomPosition();
    }
    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercentage());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
        
    }
    Vector2 GetRandomPosition()
    {
        float randomX = UnityEngine.Random.Range(minX, maxX);
        float randomY = UnityEngine.Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blocks")
        {
            SceneManager.LoadScene("Credits");
        }
        else if (Time.timeSinceLevelLoad > secondsToMaxSpeed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            
        }
    }

    float GetDifficultyPercentage()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxSpeed);
    }
}
