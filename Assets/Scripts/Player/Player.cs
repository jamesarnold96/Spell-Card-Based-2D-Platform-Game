using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool _isFacingRight;
    private CharacterController2D _controller;
    private float _normalisedHorizontalSpeed;

    public float MaxSpeed = 8;
    public float SpeedAccelerationOnGround = 10f;
    public float SpeedAccelerationInAir = 5f;

    public void Start()
    {
        _controller = GetComponent<CharacterController2D>();
        _isFacingRight = transform.localScale.x > 0;
    }

    public void Update()
    {
        if (_controller.CanJump)
            Debug.Log("yes can jump");
        else if (!_controller.CanJump)
            Debug.Log("no cant jump");
        HandleInput();

        var movementFactor = _controller.State.IsGrounded ? SpeedAccelerationOnGround : SpeedAccelerationInAir;
        _controller.SetHorizontalForce(Mathf.Lerp(_controller.Velocity.x, _normalisedHorizontalSpeed * MaxSpeed, movementFactor * Time.deltaTime));

    }

    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _normalisedHorizontalSpeed = 1;
            if (!_isFacingRight)
                Flip();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _normalisedHorizontalSpeed = -1;
            if (_isFacingRight)
                Flip();
        }
        else
        {
            _normalisedHorizontalSpeed = 0;
        }
        if (_controller.CanJump && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("trying to jump");
            _controller.Jump();
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }
}
