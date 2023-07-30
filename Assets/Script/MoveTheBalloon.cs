using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheBalloon : MonoBehaviour
{
    public float speed = 0f;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, speed, 0);
    }
}
