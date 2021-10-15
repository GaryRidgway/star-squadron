using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class SC_SpaceshipController : MonoBehaviour
{
    public float normalSpeed = 25f;
    public float accelerationSpeed = 45f;
    [Range(0.0F, 1.0F)]
    public float acceleratability = 0.5f;
    public Transform cameraPosition;
    public Camera mainCamera;
    public Transform spaceshipRoot;
    public float rotationSpeed = 2.0f;
    public float cameraSmooth = 4f;
    public RectTransform crosshairTexture;

    float speed;
    Rigidbody r;
    Quaternion lookRotation;
    float rotationZ = 0;
    float mouseXSmooth = 0;
    float mouseYSmooth = 0;
    Vector3 defaultShipRotation;
    private PlayerInput playerInput;
    private bool accelerate;
    private bool rotateRight = false;
    private bool rotateLeft = false;
    private float horizontal = 0.0f;
    private float vertical = 0.0f;
    private bool isForwardHeld = false;
    private bool isBackwardHeld = false;
    private float speedModifier = 1f;

    void Awake () {
        playerInput = new PlayerInput();

        playerInput.ShipControls.MouseMove.started += onMoveMouse;
        playerInput.ShipControls.MouseMove.canceled += onMoveMouse;
        playerInput.ShipControls.MouseMove.performed += onMoveMouse;

        playerInput.ShipControls.RotateRight.started += onRotateRight;
        playerInput.ShipControls.RotateRight.canceled += onRotateRight;

        playerInput.ShipControls.RotateLeft.started += onRotateLeft;
        playerInput.ShipControls.RotateLeft.canceled += onRotateLeft;

        playerInput.ShipControls.Accelerate.started += onAccelerate;
        playerInput.ShipControls.Accelerate.canceled += onAccelerate;


        playerInput.ShipControls.GoForward.started += onGoForward;
        playerInput.ShipControls.GoForward.canceled += onGoForward;
        playerInput.ShipControls.GoForward.performed += onGoForward;

        playerInput.ShipControls.GoBackward.started += onGoBackward;
        playerInput.ShipControls.GoBackward.canceled += onGoBackward;
        playerInput.ShipControls.GoBackward.performed += onGoBackward;
    }

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        r.useGravity = false;
        lookRotation = transform.rotation;
        defaultShipRotation = spaceshipRoot.localEulerAngles;
        rotationZ = defaultShipRotation.z;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        if (isForwardHeld && speedModifier < 1) {
            speedModifier += 0.1f * acceleratability;
            if (speedModifier > 1) {
                speedModifier = 1;
            }
        }

        if (isBackwardHeld && speedModifier > -1) {
            speedModifier -= 0.1f * acceleratability;
            if (speedModifier < -1) {
                speedModifier = -1;
            }
        }
        
        //Press Right Mouse Button to accelerate
        if (accelerate)
        {
            speed = Mathf.Lerp(speed, accelerationSpeed * speedModifier, Time.deltaTime * 3);
        }
        else
        {
            speed = Mathf.Lerp(speed, normalSpeed * speedModifier, Time.deltaTime * 10);
        }

        //Set moveDirection to the vertical axis (up and down keys) * speed
        Vector3 moveDirection = new Vector3(0, 0, speed);
        //Transform the vector3 to local space
        moveDirection = transform.TransformDirection(moveDirection);
        //Set the velocity, so you can move
        r.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);

        //Camera follow
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, cameraPosition.position, Time.deltaTime * cameraSmooth);
        mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, cameraPosition.rotation, Time.deltaTime * cameraSmooth);

        //Rotation
        float rotationZTmp = 0;
        if (rotateLeft)
        {
            rotationZTmp = 1;
        }
        else if (rotateRight)
        {
            rotationZTmp = -1;
        }
        mouseXSmooth = Mathf.Lerp(mouseXSmooth, horizontal * rotationSpeed, Time.deltaTime * cameraSmooth);
        mouseYSmooth = Mathf.Lerp(mouseYSmooth, vertical * rotationSpeed, Time.deltaTime * cameraSmooth);
        Quaternion localRotation = Quaternion.Euler(-mouseYSmooth, mouseXSmooth, rotationZTmp * rotationSpeed);
        lookRotation = lookRotation * localRotation;
        transform.rotation = lookRotation;
        rotationZ -= mouseXSmooth;
        rotationZ = Mathf.Clamp(rotationZ, -45, 45);
        spaceshipRoot.transform.localEulerAngles = new Vector3(defaultShipRotation.x, defaultShipRotation.y, rotationZ);
        rotationZ = Mathf.Lerp(rotationZ, defaultShipRotation.z, Time.deltaTime * cameraSmooth);

        //Update crosshair texture
        if (crosshairTexture)
        {
            crosshairTexture.position = mainCamera.WorldToScreenPoint(transform.position + transform.forward * 100);
        }
    }

    void onAccelerate (InputAction.CallbackContext context) {
        accelerate = context.ReadValueAsButton();
    }

    void onMoveMouse (InputAction.CallbackContext context) {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }

    void onRotateLeft (InputAction.CallbackContext context) {
        rotateLeft = context.ReadValueAsButton();
    }

    void onRotateRight (InputAction.CallbackContext context) {
        rotateRight = context.ReadValueAsButton();
    }

    void onGoForward (InputAction.CallbackContext context) {
        if (context.ReadValueAsButton()) {
            isForwardHeld = true;
        }
        else {
            isForwardHeld = false;
        }
    }

    void onGoBackward (InputAction.CallbackContext context) {
        if (context.ReadValueAsButton()) {
            isBackwardHeld = true;
        }
        else {
            isBackwardHeld = false;
        }
    }

    void OnEnable() {
        playerInput.ShipControls.Enable();
    }

    void OnDisable() {
        playerInput.ShipControls.Disable();
    }

    //context.ReadValueAsButton()
}