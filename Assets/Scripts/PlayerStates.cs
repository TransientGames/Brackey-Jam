using System;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    public AudioSource thruster;
    private Rigidbody _rigidbody;
    private PlayerAnimation _animator;
    private AudioManager _audioManager;

    public bool isActive = false;
    public bool isThirdPerson = true;
    public bool isMoving = false;
    public bool isGrounded = true;
    public bool isFlying = false;
    public bool canFly = false;
    public bool descend = false;
    public bool ascend = false;
    public bool onTop = false;
    public float currentSpeed = 3f;
    public float walkSpeed = 3f;
    public float jumpHeight = 0.5f;
    private bool _cursorLocked = true;

    [SerializeField] private LayerMask _groundMask;
    [SerializeField] private GameObject _groundCheck;
    // Bit shift the index of the layer (8) to get a bit mask
    private int _layerMask = 1 << 7;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<PlayerAnimation>();
        _audioManager = FindObjectOfType<AudioManager>();
    }

    private void Start()
    {
        if (_cursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        currentSpeed = walkSpeed;
    }

    private void Update()
    {

        isGrounded = Physics.CheckSphere(_groundCheck.transform.position, 0.4f, _groundMask);
        onTop = Physics.CheckSphere(_groundCheck.transform.position, 0.1f, _layerMask);

        if (isGrounded && onTop)
        {
            _rigidbody.useGravity = false;
        }
        else if(isFlying)
        {
            _rigidbody.useGravity = false;
        }
        else
        {
            _rigidbody.useGravity = true;
        }

        if (isGrounded && isMoving && isActive)
        {
            Sound s = Array.Find(_audioManager.sounds, sound => sound.name == "Move");
            if (s.source.isPlaying == false)
            {
                _audioManager.Play("Move");
            }
        }
        else if(isActive)
        {
            Sound s = Array.Find(_audioManager.sounds, sound => sound.name == "Move");
            if (s.source.isPlaying)
            {
                _audioManager.Stop("Move");
            }
        }

        if (isFlying)
        {
            if (thruster.isPlaying == false)
            {
                thruster.Play();
            }
        }
        else if (canFly)
        {
            if (thruster.isPlaying)
            {
                thruster.Stop();
            }
        }
    }
}
