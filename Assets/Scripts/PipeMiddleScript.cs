using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript _LogicScript;

    // Start is called before the first frame update
    void Start()
    {
        _LogicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
          _LogicScript.addScore(1);
        }        
    }
}
