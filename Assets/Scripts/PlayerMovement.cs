using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject _thirdPersonCameraArm;
    [SerializeField] private GameObject _groundCheck;
    [SerializeField] private LayerMask _groundMask;
    private PlayerAnimation _animator;
    private CharacterController _controller;
    private PlayerInputController _inputs;
    private CameraController _cameraController;
    private PlayerStates _playerStates;
    private float gravity = -25f;
    Vector3 direction;
    Vector3 velocity;
    Vector2 _rawInput;

    private void Awake()
    {
        _animator = GetComponent<PlayerAnimation>();
        _inputs = GetComponent<PlayerInputController>();
        _controller = GetComponent<CharacterController>();
        _cameraController = GetComponent<CameraController>();
        _playerStates = GetComponent<PlayerStates>();
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
            if (velocity.y < 0)
            {
                velocity.y = -2f;
            }
        }
        else
        {
            if (velocity.y < -8f)
            {
                _animator.ToggleFalling(true);
            }
        }
        _rawInput = _inputs.Movement();
        direction = (transform.forward * _rawInput.y + transform.right * _rawInput.x) * _playerStates.currentSpeed;
        print(direction);
        _controller.Move(direction * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        _controller.Move(velocity * Time.deltaTime);
    }

    public void StartMoving()
    {
        _playerStates.isMoving = true;
        if (_playerStates.isThirdPerson)
        {
            _playerStates.isMoving = true;
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
            velocity.y = Mathf.Sqrt(_playerStates.jumpHeight * -2f * gravity);
        }
    }
}
