using UnityEngine;

public class PlayerStates : MonoBehaviour
{

    private PlayerAnimation _animator;

    public bool isThirdPerson = true;
    public bool isMoving = false;
    public bool isGrounded = true;
    public bool isFlying = false;
    public bool descend = false;
    public bool ascend = false;
    public float currentSpeed = 3f;
    public float walkSpeed = 3f;
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
}
