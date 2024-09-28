using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField] private float _MoveSpeed = 1.0f;
    [SerializeField] private float _DeadZone = -15.0f;
    [SerializeField] BirdScript _BirdScript;

    private void Start()
    {
        _BirdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();        
    }

    void Update()
    {
        if (_BirdScript != null && _BirdScript._BirdIsAlive)
        {
            transform.position = transform.position + (Vector3.left * _MoveSpeed) * Time.deltaTime;
        }        

        if (transform.position.x < _DeadZone)
        {
            Destroy(gameObject);
        }
    }
}