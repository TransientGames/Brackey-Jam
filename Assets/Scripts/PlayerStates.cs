using UnityEngine;

public class PlayerStates : MonoBehaviour
{

    private PlayerAnimation _animator;

    [SerializeField] private GameObject _cameraMount;
    public bool isThirdPerson = true;
    public bool isCrouching = false;
    public bool isSprinting = false;
    public bool isSlowWalking = false;
    public bool isMoving = false;
    public bool isGrounded = true;
    public float currentSpeed = 3f;
    public float slowWalkSpeed = 1.5f;
    public float walkSpeed = 3f;
    public float sprintSpeed = 6f;
    public float jumpHeight = 0.5f;
    private bool _cursorLocked = true;

    private void Awake()
    {
        _animator = GetComponent<PlayerAnimation>();
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

    public void ToggleSprint()
    {
        if (!isCrouching)
        {
            isSprinting = !isSprinting;
            if (isSprinting)
            {
                currentSpeed = sprintSpeed;
            }
            else
            {
                currentSpeed = walkSpeed;
            }
        }
    }

    public void ToggleCrouch()
    {
        isCrouching = !isCrouching;
        _animator.ToggleCrouch(isCrouching);
        if (isCrouching)
        {
            _cameraMount.transform.Translate(0, -0.5f, 0);
            currentSpeed = slowWalkSpeed;
        }
        else
        {
            _cameraMount.transform.Translate(0, 0.5f, 0);
            currentSpeed = walkSpeed;
        }
    }
}
