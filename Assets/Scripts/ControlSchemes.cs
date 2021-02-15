// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/ControlSchemes.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlSchemes : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlSchemes()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlSchemes"",
    ""maps"": [
        {
            ""name"": ""Walk"",
            ""id"": ""ad946106-410f-4eae-a2ee-ce8daff2939b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""30fba7e2-9693-409a-ac22-ddd04ac91135"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""b01d4abe-a69e-4791-9e3b-e776840f06f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""6ee8f49e-dd9f-42da-aae6-4feae6ec4ad0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""425840ee-7d81-4ed8-ab61-c0f392317e53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TogglePerspective"",
                    ""type"": ""Button"",
                    ""id"": ""49ff6459-a398-413e-82c7-595e5653cbca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Button"",
                    ""id"": ""c21079a7-d14d-4d6b-a825-5f0afcd3906c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""370f3161-fec3-4ba8-8c7b-a5177153fc6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e9bdcd06-6077-4076-8bb5-3eec13731bc1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24e88b67-d618-4b91-8ae8-49360800128f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""417775f5-a417-4303-8c53-4adb2dbd1c91"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a91b6d69-b696-45cb-b3c6-604a5abff115"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67a98edd-9d50-4df5-a519-98c2aa0f8a96"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TogglePerspective"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae49fedc-7b7b-43d5-b3d3-dac25d941010"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e34ffde1-f40b-4d90-82f8-41353b2abf23"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Walk
        m_Walk = asset.FindActionMap("Walk", throwIfNotFound: true);
        m_Walk_Move = m_Walk.FindAction("Move", throwIfNotFound: true);
        m_Walk_Sprint = m_Walk.FindAction("Sprint", throwIfNotFound: true);
        m_Walk_Crouch = m_Walk.FindAction("Crouch", throwIfNotFound: true);
        m_Walk_Jump = m_Walk.FindAction("Jump", throwIfNotFound: true);
        m_Walk_TogglePerspective = m_Walk.FindAction("TogglePerspective", throwIfNotFound: true);
        m_Walk_Scroll = m_Walk.FindAction("Scroll", throwIfNotFound: true);
        m_Walk_Aim = m_Walk.FindAction("Aim", throwIfNotFound: true);
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

    // Walk
    private readonly InputActionMap m_Walk;
    private IWalkActions m_WalkActionsCallbackInterface;
    private readonly InputAction m_Walk_Move;
    private readonly InputAction m_Walk_Sprint;
    private readonly InputAction m_Walk_Crouch;
    private readonly InputAction m_Walk_Jump;
    private readonly InputAction m_Walk_TogglePerspective;
    private readonly InputAction m_Walk_Scroll;
    private readonly InputAction m_Walk_Aim;
    public struct WalkActions
    {
        private @ControlSchemes m_Wrapper;
        public WalkActions(@ControlSchemes wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Walk_Move;
        public InputAction @Sprint => m_Wrapper.m_Walk_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Walk_Crouch;
        public InputAction @Jump => m_Wrapper.m_Walk_Jump;
        public InputAction @TogglePerspective => m_Wrapper.m_Walk_TogglePerspective;
        public InputAction @Scroll => m_Wrapper.m_Walk_Scroll;
        public InputAction @Aim => m_Wrapper.m_Walk_Aim;
        public InputActionMap Get() { return m_Wrapper.m_Walk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkActions set) { return set.Get(); }
        public void SetCallbacks(IWalkActions instance)
        {
            if (m_Wrapper.m_WalkActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnJump;
                @TogglePerspective.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnTogglePerspective;
                @TogglePerspective.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnTogglePerspective;
                @TogglePerspective.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnTogglePerspective;
                @Scroll.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Aim.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_WalkActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TogglePerspective.started += instance.OnTogglePerspective;
                @TogglePerspective.performed += instance.OnTogglePerspective;
                @TogglePerspective.canceled += instance.OnTogglePerspective;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public WalkActions @Walk => new WalkActions(this);
    public interface IWalkActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTogglePerspective(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
