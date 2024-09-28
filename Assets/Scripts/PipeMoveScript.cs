using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField] private float _MoveSpeed = 1.0f;
    [SerializeField] private float _DeadZone = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * _MoveSpeed) * Time.deltaTime;

        if (transform.position.x < _DeadZone)
        {
            Destroy(gameObject);
        }
    }
}