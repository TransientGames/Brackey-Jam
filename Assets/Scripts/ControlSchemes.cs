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
                    ""type"": ""PassThrough"",
                    ""id"": ""30fba7e2-9693-409a-ac22-ddd04ac91135"",
                    ""expectedControlType"": ""Vector2"",
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
                    ""name"": ""ToggleCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""49ff6459-a398-413e-82c7-595e5653cbca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c21079a7-d14d-4d6b-a825-5f0afcd3906c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""370f3161-fec3-4ba8-8c7b-a5177153fc6f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Descend"",
                    ""type"": ""Button"",
                    ""id"": ""0e3cc587-5104-4871-9295-74ae7a7f5fac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1db9c9ec-c14c-4d56-9512-fe86249f0067"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8c01dc00-46dc-40c0-aeda-0d4abad0f8c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6fb1524e-89ee-4c5d-8456-fa5995b98e35"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0ef6e514-30b8-46a1-89f2-2ceeb97d7f23"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2a00d51d-6403-4131-9013-de40d056d32c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""path"": ""<Keyboard>/space"",
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
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae49fedc-7b7b-43d5-b3d3-dac25d941010"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e34ffde1-f40b-4d90-82f8-41353b2abf23"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aea20a8b-14fa-4d24-8bd1-22948619804f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Descend"",
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
        m_Walk_ToggleCharacter = m_Walk.FindAction("ToggleCharacter", throwIfNotFound: true);
        m_Walk_Scroll = m_Walk.FindAction("Scroll", throwIfNotFound: true);
        m_Walk_Aim = m_Walk.FindAction("Aim", throwIfNotFound: true);
        m_Walk_Descend = m_Walk.FindAction("Descend", throwIfNotFound: true);
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
    private readonly InputAction m_Walk_ToggleCharacter;
    private readonly InputAction m_Walk_Scroll;
    private readonly InputAction m_Walk_Aim;
    private readonly InputAction m_Walk_Descend;
    public struct WalkActions
    {
        private @ControlSchemes m_Wrapper;
        public WalkActions(@ControlSchemes wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Walk_Move;
        public InputAction @Sprint => m_Wrapper.m_Walk_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Walk_Crouch;
        public InputAction @Jump => m_Wrapper.m_Walk_Jump;
        public InputAction @ToggleCharacter => m_Wrapper.m_Walk_ToggleCharacter;
        public InputAction @Scroll => m_Wrapper.m_Walk_Scroll;
        public InputAction @Aim => m_Wrapper.m_Walk_Aim;
        public InputAction @Descend => m_Wrapper.m_Walk_Descend;
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
                @ToggleCharacter.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnToggleCharacter;
                @ToggleCharacter.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnToggleCharacter;
                @ToggleCharacter.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnToggleCharacter;
                @Scroll.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnScroll;
                @Aim.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnAim;
                @Descend.started -= m_Wrapper.m_WalkActionsCallbackInterface.OnDescend;
                @Descend.performed -= m_Wrapper.m_WalkActionsCallbackInterface.OnDescend;
                @Descend.canceled -= m_Wrapper.m_WalkActionsCallbackInterface.OnDescend;
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
                @ToggleCharacter.started += instance.OnToggleCharacter;
                @ToggleCharacter.performed += instance.OnToggleCharacter;
                @ToggleCharacter.canceled += instance.OnToggleCharacter;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Descend.started += instance.OnDescend;
                @Descend.performed += instance.OnDescend;
                @Descend.canceled += instance.OnDescend;
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
        void OnToggleCharacter(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnDescend(InputAction.CallbackContext context);
    }
}
