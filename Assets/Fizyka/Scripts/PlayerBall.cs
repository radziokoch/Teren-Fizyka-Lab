using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public List<GameObject> balls;
    public Transform place;
    public float speed = 100;

    public float timeMax = .3f;
    private float time;
    private int ballIndex = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && time > timeMax)
        {
            GameObject gameObject1 = Instantiate(balls[ballIndex], place.position, Quaternion.identity);
            gameObject1.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * speed);
            time = 0;
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ballIndex = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ballIndex = 1;
        }

        time += Time.deltaTime;
    }
}
