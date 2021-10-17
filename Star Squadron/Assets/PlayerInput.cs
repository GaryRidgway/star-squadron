// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""ShipControls"",
            ""id"": ""16734bdb-60e4-470e-b111-78c9c6f0a623"",
            ""actions"": [
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""ef06ac6b-cae4-4bdc-9833-189430f82fb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d5368bdc-cc0f-4863-809b-40a8c988bf71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7d9bdea7-ad38-4c78-ae48-2f17f3b4f588"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""d741cb93-825f-49d3-9110-5bdb66e6dfed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoForward"",
                    ""type"": ""Button"",
                    ""id"": ""401583b9-8f11-4a70-8cde-acbba57cf161"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoBackward"",
                    ""type"": ""Button"",
                    ""id"": ""4ff23643-0258-4cdb-8468-80f30b1308b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireWeapons"",
                    ""type"": ""Button"",
                    ""id"": ""eb933cb8-9b6c-4c86-aef6-79b517835693"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56ae9710-b052-4279-92e3-ce55e4a9af8b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dffd9801-d331-4f8a-8d3a-6d2940ad526e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""MouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a49d88db-b794-456b-95d6-520fbc9db7f3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e715a039-c45a-46f8-b398-52189b0d680f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""403c15f3-446c-4a72-98fd-ba943ae01338"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b95fce5-bd38-441c-b016-dfd979084665"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""795d9389-931e-460e-bc56-7be6b8af15b0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireWeapons"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ShipControls
        m_ShipControls = asset.FindActionMap("ShipControls", throwIfNotFound: true);
        m_ShipControls_RotateRight = m_ShipControls.FindAction("RotateRight", throwIfNotFound: true);
        m_ShipControls_RotateLeft = m_ShipControls.FindAction("RotateLeft", throwIfNotFound: true);
        m_ShipControls_MouseMove = m_ShipControls.FindAction("MouseMove", throwIfNotFound: true);
        m_ShipControls_Accelerate = m_ShipControls.FindAction("Accelerate", throwIfNotFound: true);
        m_ShipControls_GoForward = m_ShipControls.FindAction("GoForward", throwIfNotFound: true);
        m_ShipControls_GoBackward = m_ShipControls.FindAction("GoBackward", throwIfNotFound: true);
        m_ShipControls_FireWeapons = m_ShipControls.FindAction("FireWeapons", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ShipControls
    private readonly InputActionMap m_ShipControls;
    private IShipControlsActions m_ShipControlsActionsCallbackInterface;
    private readonly InputAction m_ShipControls_RotateRight;
    private readonly InputAction m_ShipControls_RotateLeft;
    private readonly InputAction m_ShipControls_MouseMove;
    private readonly InputAction m_ShipControls_Accelerate;
    private readonly InputAction m_ShipControls_GoForward;
    private readonly InputAction m_ShipControls_GoBackward;
    private readonly InputAction m_ShipControls_FireWeapons;
    public struct ShipControlsActions
    {
        private @PlayerInput m_Wrapper;
        public ShipControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateRight => m_Wrapper.m_ShipControls_RotateRight;
        public InputAction @RotateLeft => m_Wrapper.m_ShipControls_RotateLeft;
        public InputAction @MouseMove => m_Wrapper.m_ShipControls_MouseMove;
        public InputAction @Accelerate => m_Wrapper.m_ShipControls_Accelerate;
        public InputAction @GoForward => m_Wrapper.m_ShipControls_GoForward;
        public InputAction @GoBackward => m_Wrapper.m_ShipControls_GoBackward;
        public InputAction @FireWeapons => m_Wrapper.m_ShipControls_FireWeapons;
        public InputActionMap Get() { return m_Wrapper.m_ShipControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControlsActions set) { return set.Get(); }
        public void SetCallbacks(IShipControlsActions instance)
        {
            if (m_Wrapper.m_ShipControlsActionsCallbackInterface != null)
            {
                @RotateRight.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRotateRight;
                @RotateLeft.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRotateLeft;
                @MouseMove.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouseMove;
                @MouseMove.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouseMove;
                @MouseMove.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouseMove;
                @Accelerate.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnAccelerate;
                @GoForward.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnGoForward;
                @GoForward.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnGoForward;
                @GoForward.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnGoForward;
                @GoBackward.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnGoBackward;
                @GoBackward.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnGoBackward;
                @GoBackward.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnGoBackward;
                @FireWeapons.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFireWeapons;
                @FireWeapons.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFireWeapons;
                @FireWeapons.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFireWeapons;
            }
            m_Wrapper.m_ShipControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @MouseMove.started += instance.OnMouseMove;
                @MouseMove.performed += instance.OnMouseMove;
                @MouseMove.canceled += instance.OnMouseMove;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @GoForward.started += instance.OnGoForward;
                @GoForward.performed += instance.OnGoForward;
                @GoForward.canceled += instance.OnGoForward;
                @GoBackward.started += instance.OnGoBackward;
                @GoBackward.performed += instance.OnGoBackward;
                @GoBackward.canceled += instance.OnGoBackward;
                @FireWeapons.started += instance.OnFireWeapons;
                @FireWeapons.performed += instance.OnFireWeapons;
                @FireWeapons.canceled += instance.OnFireWeapons;
            }
        }
    }
    public ShipControlsActions @ShipControls => new ShipControlsActions(this);
    public interface IShipControlsActions
    {
        void OnRotateRight(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnMouseMove(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnGoForward(InputAction.CallbackContext context);
        void OnGoBackward(InputAction.CallbackContext context);
        void OnFireWeapons(InputAction.CallbackContext context);
    }
}
