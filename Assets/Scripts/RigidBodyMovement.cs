using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    [SerializeField] private GameObject _thirdPersonCameraArm;
    [SerializeField] private GameObject _groundCheck;
    [SerializeField] private LayerMask _groundMask;
    //[SerializeField] private float _fallingVelocity = 8f;
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private bool _canFly = false;
    [SerializeField] GameObject _model;
    private Rigidbody _rigidBody;
    private PlayerAnimation _animator;
    private CharacterController _controller;
    private PlayerInputController _inputs;
    private CameraController _cameraController;
    private PlayerStates _playerStates;
    private Vector3 direction;
    private Vector2 _rawInput;
    private Vector3 _default = new Vector3(0, 0, 0);
    private Vector3 _flyRotation = new Vector3(-70f, 0, 0);
    private Vector3 _flyPosition = new Vector3(0, 0.6f, 0);

    private void Awake()
    {
        _animator = GetComponent<PlayerAnimation>();
        _inputs = GetComponent<PlayerInputController>();
        _controller = GetComponent<CharacterController>();
        _cameraController = GetComponent<CameraController>();
        _playerStates = GetComponent<PlayerStates>();
        _rigidBody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        Move();
    }

    public void Move()
    {
        _playerStates.isGrounded = Physics.CheckSphere(_groundCheck.transform.position, 0.4f, _groundMask);
        
        if (_playerStates.isGrounded)
        {
            _animator.ToggleFalling(false);

            if (_canFly)
            {
                _playerStates.isFlying = false;
                _animator.ToggleFlying(false);
                _model.transform.localEulerAngles = _default;
                _model.transform.localPosition = _default;
                _rigidBody.useGravity = true;
            }
        }
        else
        {
            _animator.ToggleFalling(true);

            if (_playerStates.isFlying)
            {
                if (_playerStates.descend)
                {
                    transform.Translate(Vector3.down * _playerStates.currentSpeed * Time.deltaTime, Space.World);
                }
                else if (_playerStates.ascend)
                {
                    transform.Translate(Vector3.up * _playerStates.currentSpeed * Time.deltaTime, Space.World);
                }
            }
        }

        _rawInput = _inputs.Movement();
        direction = (transform.forward * _rawInput.y + transform.right * _rawInput.x) * _playerStates.currentSpeed * Time.deltaTime;
        transform.Translate(direction, Space.World);
    }

    public void StartMoving()
    {
        _playerStates.isMoving = true;
        if (_playerStates.isThirdPerson)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, _thirdPersonCameraArm.transform.eulerAngles.y, transform.eulerAngles.z);
            _cameraController.ResetThirdPersonCamera();
        }
    }

    public void StopMoving()
    {
        _playerStates.isMoving = false;
    }

    public void Jump()
    {
        if (_playerStates.isGrounded)
        {
            _animator.Jumped();
            _rigidBody.velocity = new Vector3(_rigidBody.velocity.x, _jumpForce, _rigidBody.velocity.z);
        }
        else if (_canFly && _playerStates.isFlying == false)
        {
            _playerStates.isFlying = true;
            _animator.ToggleFlying(true);
            _rigidBody.useGravity = false;
            _rigidBody.velocity = new Vector3(0,0,0);
            _model.transform.localEulerAngles = _flyRotation;
            _model.transform.localPosition = _flyPosition;
        }
    }
}
