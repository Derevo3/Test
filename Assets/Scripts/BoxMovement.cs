using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public Transform tf;
    public GameObject box;

    public float speed;
    public float distance;

    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        if (transform.position.x >= distance)
            Destroy(box);
    }
}