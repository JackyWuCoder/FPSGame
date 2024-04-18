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

    private void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
