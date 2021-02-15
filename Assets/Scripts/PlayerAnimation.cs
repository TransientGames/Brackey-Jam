using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator _animator;
    private PlayerStates _playerState;
    private PlayerInputController _inputs;
    private Vector2 _movement;


    private void Awake()
    {
        _animator = gameObject.GetComponentInChildren<Animator>();
        _playerState = GetComponent<PlayerStates>();
        _inputs = GetComponent<PlayerInputController>();
    }

    private void FixedUpdate()
    {
        Animate();
    }

    private void Animate()
    {
        _movement = _inputs.Movement();
        if (_playerState.isSprinting)
        {
            _movement *= 2;
        }
        _animator.SetFloat("Velocity Z", _movement.y);
        _animator.SetFloat("Velocity X", _movement.x);
    }

    public void ToggleCrouch(bool state)
    {
        _animator.SetBool("isCrouching", state);
    }
    
    public void Jumped()
    {
        _animator.SetTrigger("Jumped");
    }

    public void ToggleFalling(bool state)
    {
        _animator.SetBool("isFalling", state);
    }
}
