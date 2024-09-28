using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject _Pipe;
    [SerializeField] float _SpawnRate;
    [SerializeField] float _Timer;
    [SerializeField] float _HeightOffset = 1;
    [SerializeField] BirdScript _BirdScript;

    void Update()
    {
        if (_Timer < _SpawnRate)
        {
            _Timer += Time.deltaTime;
        }
        else if (_BirdScript != null && _BirdScript._BirdIsAlive)
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