using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Drawing;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    private UIManager _uiManager;

    private CharacterController _controller;
    private ControlSchemes _playerControls;

    private Animator _animator;
    //[SerializeField] private Animator _cameraStateController;

    private Vector2 _rawMovement;

    [SerializeField] private GameObject _firstPersonCamera;
    [SerializeField] private GameObject _thirdPersonCamera;
    [SerializeField] private GameObject _thirdPersonCameraMount;
    private float _mouseHorizontalSensitivity = 0.15f;
    private float _mouseVerticalSensitivity = 0.15f;
    private float _cameraPitch;
    private bool _isThirdPerson = false;
    private bool _cursorLocked = true;

    private float _speed;
    private float _walkingSpeed = 3f;
    private float _sprintSpeed = 6f;
    private float _transitionTime = 8f;
    private bool _isSprinting = false;

    private bool _isCrouching = false;

    private void Awake()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        _playerControls = new ControlSchemes();
        _playerControls.Walk.Sprint.performed += x => _isSprinting = !_isSprinting;
        _playerControls.Walk.Crouch.performed += x => _isCrouching = !_isCrouching;
        _playerControls.Walk.TogglePerspective.performed += x => TogglePerspective();

        _animator = gameObject.GetComponentInChildren<Animator>();
        if (_animator == null)
        {
            Debug.LogError("Could Not Find Animator Component on Player!");
        }

    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    void Start()
    {
        _speed = _walkingSpeed;
        _controller = GetComponent<CharacterController>();
        if (_cursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // test remove later and probly set _isThirdPerson to false by default
        //_isThirdPerson = true;
        //_cameraStateController.SetBool("IsThirdPerson", _isThirdPerson);

        if (_isThirdPerson)
        {
            _thirdPersonCamera.SetActive(true);
            _firstPersonCamera.SetActive(false);
        }
    }

    void Update()
    {
        NewLook();
        Move();
    }

    private void FixedUpdate()
    {
        //Animate();
        //Aim();
    }

    private void NewLook()
    {
        Vector2 rawAim = _playerControls.Walk.Aim.ReadValue<Vector2>();

        _cameraPitch -= rawAim.y * _mouseVerticalSensitivity;
        _cameraPitch = Mathf.Clamp(_cameraPitch, -90f, 90f);

        if (_isThirdPerson)
        {
            _thirdPersonCameraMount.transform.Rotate(Vector3.up * rawAim.x * _mouseHorizontalSensitivity, Space.World);
            _thirdPersonCameraMount.transform.Rotate(Vector3.right * rawAim.y * _mouseVerticalSensitivity * -1f, Space.Self);
        }
        else
        {
            _firstPersonCamera.transform.localEulerAngles = Vector3.right * _cameraPitch;
            transform.Rotate(Vector3.up * rawAim.x * _mouseHorizontalSensitivity);
        }
    }

    // remove once new camera system works
    private void Look()
    {
        Vector2 rawAim = _playerControls.Walk.Aim.ReadValue<Vector2>();
        
        _cameraPitch -= rawAim.y * _mouseVerticalSensitivity;
        _cameraPitch = Mathf.Clamp(_cameraPitch, -90f, 90f);

        if (_isThirdPerson)
        {
            _thirdPersonCameraMount.transform.Rotate(Vector3.up * rawAim.x * _mouseHorizontalSensitivity);
        }
        else
        {
            //_currentCamera.transform.localEulerAngles = Vector3.right * _cameraPitch;
            transform.Rotate(Vector3.up * rawAim.x * _mouseHorizontalSensitivity);
        }
    }

    /*
    private void Aim()
    {
        Ray ray = _currentCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2.5f))
        {
            _uiManager.UpdateTargetText(hit.transform.name);
        }
        else
        {
            _uiManager.UpdateTargetText("");
        }
    }
    */

    private void Move()
    {
        _rawMovement = _playerControls.Walk.Move.ReadValue<Vector2>();
        
        if (_isSprinting && _speed < _sprintSpeed)
        {
            _speed = Mathf.Lerp(_speed, _sprintSpeed, Time.deltaTime * _transitionTime);
        }
        if (!_isSprinting && _speed > _walkingSpeed)
        {
            _speed = Mathf.Lerp(_speed, _walkingSpeed, Time.deltaTime * _transitionTime);
        }

        Vector3 velocity = (transform.forward * _rawMovement.y + transform.right * _rawMovement.x) * _speed;
        _controller.Move(velocity * Time.deltaTime);
    }

    
    
    private void TogglePerspective()
    {
        _isThirdPerson = !_isThirdPerson;
        //_cameraStateController.SetBool("IsThirdPerson", _isThirdPerson);
        if (_isThirdPerson)
        {
            _thirdPersonCamera.SetActive(true);
            _firstPersonCamera.SetActive(false);
        }
        else
        {
            _firstPersonCamera.SetActive(true);
            _thirdPersonCamera.SetActive(false);
        }
    }
    
}
