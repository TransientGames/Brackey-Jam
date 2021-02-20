using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _thirdPersonCamera;
    [SerializeField] private GameObject _thirdPersonCameraArm;
    private PlayerInputController _inputs;
    private PlayerStates _playerStates;

    private float _cameraPitch;
    private float _thirdPersonCamRot;
    private float _thirdPersonCameraFollowMinDistance = 1f;
    private float _thirdPersonCameraFollowMaxDistance = 1f;
    private float _thirdPersonCameraFollowMaxMaxDistance = 2f;
    private Vector3 _thirdPersonCameraDolly;
    private float _thirdPersonCameraDistance;
    private float _thirdPersonCameraSmooth = 5f;

    private float _mouseVerticalSensitivity = 0.1f;
    private float _mouseHorizontalSensitivity = 0.15f;

    private void Awake()
    {
        _inputs = GetComponent<PlayerInputController>();
        _playerStates = GetComponent<PlayerStates>();
    }

    private void OnEnable()
    {
        _playerStates.isActive = true;
    }

    private void OnDisable()
    {
        _playerStates.isActive = false;
    }

    void Start()
    {
        _thirdPersonCameraDolly = _thirdPersonCamera.transform.localPosition.normalized;
        _thirdPersonCameraDistance = _thirdPersonCamera.transform.localPosition.magnitude;
        _thirdPersonCamRot = _thirdPersonCameraArm.transform.localEulerAngles.x;
        _thirdPersonCameraFollowMaxDistance = _thirdPersonCameraFollowMaxMaxDistance;
    }

    void Update()
    {
        Look();
    }
     
    private void Look()
    {
        Vector2 rawAim = _inputs.Look();
        
        _cameraPitch -= rawAim.y * _mouseVerticalSensitivity;
        _cameraPitch = Mathf.Clamp(_cameraPitch, -90f, 90f);

        if (_playerStates.isThirdPerson)
        {
            if (_playerStates.isMoving)
            {
                transform.Rotate(Vector3.up * rawAim.x * _mouseHorizontalSensitivity);
            }
            else
            {
                _thirdPersonCamRot += rawAim.x * _mouseHorizontalSensitivity;
            }

            _thirdPersonCameraArm.transform.localEulerAngles = new Vector3(_cameraPitch, _thirdPersonCamRot, 0.0f);

            Vector3 desiredCamPosition = _thirdPersonCamera.transform.parent.TransformPoint(_thirdPersonCameraDolly * _thirdPersonCameraFollowMaxDistance);
            RaycastHit hit;
            if (Physics.Linecast(_thirdPersonCamera.transform.parent.position, desiredCamPosition, out hit))
            {
                _thirdPersonCameraDistance = Mathf.Clamp(hit.distance, _thirdPersonCameraFollowMinDistance, _thirdPersonCameraFollowMaxDistance);
            }
            else
            {
                _thirdPersonCameraDistance = _thirdPersonCameraFollowMaxDistance;
            }
            _thirdPersonCamera.transform.localPosition = Vector3.Lerp(_thirdPersonCamera.transform.localPosition, _thirdPersonCameraDolly * _thirdPersonCameraDistance, Time.deltaTime * _thirdPersonCameraSmooth);
        }
        else
        {
            //_firstPersonCamera.transform.localEulerAngles = Vector3.right * _cameraPitch;
            transform.Rotate(Vector3.up * rawAim.x * _mouseHorizontalSensitivity);
        }
    }

    public void ThirPersonCamFollowDistance(float value)
    {
        if (_playerStates.isThirdPerson)
        {
            if (value > 0 && _thirdPersonCameraDistance > _thirdPersonCameraFollowMinDistance)
            {
                _thirdPersonCameraFollowMaxDistance -= 0.1f;
            }
            else if (value < 0 && _thirdPersonCameraDistance < _thirdPersonCameraFollowMaxMaxDistance)
            {
                _thirdPersonCameraFollowMaxDistance += 0.1f;
            }
        }
    }

    public void ResetThirdPersonCamera()
    {
        _thirdPersonCamRot = 0f;
    }
}
