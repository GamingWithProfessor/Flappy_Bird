using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _Rigidbody;
    [SerializeField] private float _FlapStrength;

    [SerializeField] private LogicScript _LogicScript;
    public bool _BirdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        _LogicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _BirdIsAlive == true)
        {
            _Rigidbody.velocity = Vector2.up * _FlapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _LogicScript.GameOver();
        _BirdIsAlive = false;
    }
}
