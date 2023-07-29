using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPos;

    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime); 

        if(transform.position.y < -1400f)
        {
            transform.position = StartPos;
        }

    }
}
