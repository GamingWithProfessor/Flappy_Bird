using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject _Pipe;
    [SerializeField] float _SpawnRate;
    [SerializeField] float _Timer;
    [SerializeField] float _HeightOffset = 1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_Timer < _SpawnRate)
        {
            _Timer = _Timer + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            _Timer = 0;
        }        
    }

    void SpawnPipe()
    {
        float LowestPoint = transform.position.y - _HeightOffset;
        float HighestPoint = transform.position.y + _HeightOffset;

        Instantiate(_Pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0), transform.rotation);
    }
}
