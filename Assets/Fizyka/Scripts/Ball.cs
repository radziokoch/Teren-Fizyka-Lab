using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int pointsMultiplier = 1;
    float currentLifeTime = 0;
    public static float maxLifeTime = 5;

    private void Update()
    {
        if(currentLifeTime > maxLifeTime)
        {
            Destroy(gameObject);
        }
        currentLifeTime += Time.deltaTime;
    }
}
