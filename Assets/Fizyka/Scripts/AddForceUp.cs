using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceUp : MonoBehaviour
{
    public Vector3 direction;
    public float maxTime = 1;
    private float time;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(time > maxTime)
        {
            GetComponent<Rigidbody>().AddForce(direction);
            time = 0;
        }

        time += Time.deltaTime;
    }
}
