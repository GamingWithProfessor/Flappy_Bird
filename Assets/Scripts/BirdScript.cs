using System.Collections;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _Rigidbody;
    [SerializeField] private float _FlapStrength;

    [SerializeField] LogicScript _LogicScript;
    [SerializeField] public bool _BirdIsAlive = true;

    [SerializeField] private AudioClip _JumpSound;
    [SerializeField] private AudioClip _DeathSound;
    [SerializeField] private AudioSource _audioSource;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        _LogicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _BirdIsAlive == true)
        {
            _Rigidbody.velocity = Vector2.up * _FlapStrength;
            _audioSource.PlayOneShot(_JumpSound);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _audioSource.PlayOneShot(_DeathSound);
        _LogicScript.GameOver();
        _BirdIsAlive = false;
    }
}
