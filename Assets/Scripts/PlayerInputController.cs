using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    //private PlayerMovement _playerMovement;
    private RigidBodyMovement _rigidBodyMovement;
    private CameraController _cameraController;
    private PlayerStates _playerStates;
    private ControlSchemes _playerControls;
    private Rigidbody _rigidbody;

    public GameObject otherCharacter;
    public GameObject otherCamera;
    public GameObject myCamera;


    private void Awake()
    {
        //_playerMovement = GetComponent<PlayerMovement>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidBodyMovement = GetComponent<RigidBodyMovement>();
        _cameraController = GetComponent<CameraController>();
        _playerStates = GetComponent<PlayerStates>();
        _playerControls = new ControlSchemes();
        //_playerControls.Walk.Jump.performed += x => _playerMovement.Jump();
        _playerControls.Walk.Jump.performed += x => _rigidBodyMovement.Jump();
        _playerControls.Walk.Descend.started += x => _playerStates.descend = true;
        _playerControls.Walk.Descend.canceled += x => _playerStates.descend = false;
        _playerControls.Walk.Jump.started += x => _playerStates.ascend = true;
        _playerControls.Walk.Jump.canceled += x => _playerStates.ascend = false;
        _playerControls.Walk.ToggleCharacter.performed += x => ToggleCharacter();
        _playerControls.Walk.Scroll.performed += x => _cameraController.ThirPersonCamFollowDistance(x.ReadValue<float>());
        //_playerControls.Walk.Move.performed += x => _playerMovement.StartMoving();
        _playerControls.Walk.Move.performed += x => _rigidBodyMovement.StartMoving();
        //_playerControls.Walk.Move.canceled += x => _playerMovement.StopMoving();
        _playerControls.Walk.Move.canceled += x => _rigidBodyMovement.StopMoving();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    public Vector2 Movement()
    {
        return _playerControls.Walk.Move.ReadValue<Vector2>();
    }

    public Vector2 Look()
    {
        return _playerControls.Walk.Aim.ReadValue<Vector2>();
    }

    private void ToggleCharacter()
    {
        if (_rigidBodyMovement.canFly)
        {
            if (_playerStates.isFlying)
            {
                _rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
            else
            {
                _rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
            }
        }
        else
        {
            _rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
        }
        otherCharacter.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        otherCharacter.GetComponent<PlayerInputController>().enabled = true;
        otherCharacter.GetComponent<RigidBodyMovement>().enabled = true;
        otherCharacter.GetComponent<CameraController>().enabled = true;
        otherCamera.SetActive(true);
        

        _rigidBodyMovement.enabled = false;
        _cameraController.enabled = false;
        myCamera.SetActive(false);
        gameObject.GetComponent<PlayerInputController>().enabled = false;
    }
}
