using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // reference to the PlayerInput Class
    private PlayerInput playerInput;
    // reference to the OnFoot Action Map
    private PlayerInput.OnFootActions onFoot;
    private PlayerMotor motor;

    private void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
    }

    void FixedUpdate()
    {
        // Tell the player motor to move using the value from our movement action
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        // enable our OnFoot Action Map
        onFoot.Enable();
    }

    private void OnDisable()
    {
        // disable our OnFoot Action Map
        onFoot.Disable();
    }
}
