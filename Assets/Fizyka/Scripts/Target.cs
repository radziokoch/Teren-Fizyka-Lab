using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public static int amount = 0;
    private void Start()
    {
        amount++;
    }

    public PointsController pointsController;
    public int points = 1;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Ball ball = other.gameObject.GetComponent<Ball>();
            pointsController.AddScore(ball.pointsMultiplier * points);
            pointsController.AddTargetShoot();
            Destroy(gameObject);
        }
    }
}
