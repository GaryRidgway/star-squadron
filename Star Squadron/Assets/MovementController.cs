using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    private PlayerInput playerInput;
    
    void Awake () {
        playerInput = new PlayerInput();

        playerInput.ShipControls.MouseMove.started += onMoveMouse;
        playerInput.ShipControls.MouseMove.canceled += onMoveMouse;
        playerInput.ShipControls.MouseMove.performed += onMoveMouse;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onMoveMouse (InputAction.CallbackContext context) {
        Debug.Log(context);
    }

    void onWPress (InputAction.CallbackContext context) {
        Debug.Log(context);
    }

    void OnEnable() {
        playerInput.ShipControls.Enable();
    }

    void OnDisable() {
        playerInput.ShipControls.Disable();
    }
}
