using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private CameraController _cameraController;
    private PlayerStates _playerStates;
    private ControlSchemes _playerControls;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _cameraController = GetComponent<CameraController>();
        _playerStates = GetComponent<PlayerStates>();
        _playerControls = new ControlSchemes();
        _playerControls.Walk.Sprint.performed += x => _playerStates.ToggleSprint();
        _playerControls.Walk.Crouch.performed += x => _playerStates.ToggleCrouch();
        _playerControls.Walk.Jump.performed += x => _playerMovement.Jump();
        _playerControls.Walk.TogglePerspective.performed += x => _cameraController.TogglePerspective();
        _playerControls.Walk.Scroll.performed += x => _cameraController.ThirPersonCamFollowDistance(x.ReadValue<float>());
        _playerControls.Walk.Move.performed += x => _playerMovement.StartMoving();
        _playerControls.Walk.Move.canceled += x => _playerMovement.StopMoving();
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
}
