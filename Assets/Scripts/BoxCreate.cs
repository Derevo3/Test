using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCreate : MonoBehaviour
{
    public GameObject gO;
    private float createTime;
    public float delayTime;

    void Start()
    {
        createTime = delayTime;
    }

    void Update()
    {
        if (createTime <= 0)
        {
            Instantiate(gO, gO.transform.position, Quaternion.identity);
            createTime = delayTime;
        }
        else
            createTime -= Time.deltaTime;
    }

}
