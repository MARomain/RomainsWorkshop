// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameplayPad"",
            ""id"": ""6b300cd9-d9ec-412d-81ee-293fab382a9b"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""25c58e01-1498-4f17-9533-766a4d0b5b49"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""fadfc33f-0135-478a-92e2-6cc6618f6f99"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""87d75717-ea10-4b8f-b1c0-87135c0e5d22"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnyKey"",
                    ""type"": ""Button"",
                    ""id"": ""6fd3ce6e-e199-4350-9811-a35ff0a03d38"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap"",
                    ""type"": ""Button"",
                    ""id"": ""062039b7-a740-454f-bdd5-63b0b0d5bbf0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""90aed8df-4466-41c9-bd91-a826c203b01f"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6ab6818-62bb-44c7-857a-f5e8535675ea"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a485e274-cb51-49e0-b1d4-5666001e5630"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ff1c6fe-26a0-4a07-aa69-d2d149d453b4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc4263d2-4e33-42d1-a7ec-6e54e93299a1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a97b0f1-a8d1-4f50-bd29-68256e35b2e1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2682d890-de68-4310-b5cc-7b92f8ec5b33"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54dcb472-bfda-4e07-9c26-80b591b7a84c"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8627db8a-e223-4f9c-8f84-86fdb50d624b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39527073-ea7a-47cc-958b-008988c5d3eb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bcdc610-5437-4bbc-ba6f-d9f4e2ec9c97"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3541feaf-cd67-48ee-b484-592bda0c9936"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27cc76b0-bfc2-4833-a0a8-fe46ac9cffaa"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69cda957-107d-4278-8286-2e0a481a6629"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc0d76b9-4232-4c75-a653-50df473d555b"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d00b8bfc-054e-46b2-91db-55aa7b529299"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc32bf38-8177-4c5e-b1dc-3f9f0b3debd1"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae67a11b-4429-4020-b07a-eafafbcce998"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cc4fef1-4573-479d-bb7e-50ea68847452"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameplayMk"",
            ""id"": ""a86e23da-38e4-40fb-a989-57adb3e4e3c4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""9588dd9b-953f-4b9e-b7d6-9828b33d3cb7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""f9fd9af5-2429-4707-a0ea-1cda55a1c97b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""6a3e1012-d411-4597-8148-26afd1490ded"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1a8801e2-d4ae-4eec-b185-ac2e2a5debff"",
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
                    ""id"": ""c39b1568-c70e-48d2-9ab9-77af60b389fd"",
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
                    ""id"": ""cedc69f3-0204-410d-bab7-89b1ffd027b1"",
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
                    ""id"": ""c65cb431-73c5-4332-ac05-31f0bcea74c3"",
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
                    ""id"": ""b29786a8-464a-48cb-9b96-6a8c8d444e8c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayPad
        m_GameplayPad = asset.FindActionMap("GameplayPad", throwIfNotFound: true);
        m_GameplayPad_Grow = m_GameplayPad.FindAction("Grow", throwIfNotFound: true);
        m_GameplayPad_Move = m_GameplayPad.FindAction("Move", throwIfNotFound: true);
        m_GameplayPad_Rotate = m_GameplayPad.FindAction("Rotate", throwIfNotFound: true);
        m_GameplayPad_AnyKey = m_GameplayPad.FindAction("AnyKey", throwIfNotFound: true);
        m_GameplayPad_Swap = m_GameplayPad.FindAction("Swap", throwIfNotFound: true);
        // GameplayMk
        m_GameplayMk = asset.FindActionMap("GameplayMk", throwIfNotFound: true);
        m_GameplayMk_Move = m_GameplayMk.FindAction("Move", throwIfNotFound: true);
        m_GameplayMk_Look = m_GameplayMk.FindAction("Look", throwIfNotFound: true);
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

    // GameplayPad
    private readonly InputActionMap m_GameplayPad;
    private IGameplayPadActions m_GameplayPadActionsCallbackInterface;
    private readonly InputAction m_GameplayPad_Grow;
    private readonly InputAction m_GameplayPad_Move;
    private readonly InputAction m_GameplayPad_Rotate;
    private readonly InputAction m_GameplayPad_AnyKey;
    private readonly InputAction m_GameplayPad_Swap;
    public struct GameplayPadActions
    {
        private PlayerControls m_Wrapper;
        public GameplayPadActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_GameplayPad_Grow;
        public InputAction @Move => m_Wrapper.m_GameplayPad_Move;
        public InputAction @Rotate => m_Wrapper.m_GameplayPad_Rotate;
        public InputAction @AnyKey => m_Wrapper.m_GameplayPad_AnyKey;
        public InputAction @Swap => m_Wrapper.m_GameplayPad_Swap;
        public InputActionMap Get() { return m_Wrapper.m_GameplayPad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayPadActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayPadActions instance)
        {
            if (m_Wrapper.m_GameplayPadActionsCallbackInterface != null)
            {
                Grow.started -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnGrow;
                Grow.performed -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnGrow;
                Grow.canceled -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnGrow;
                Move.started -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnMove;
                Rotate.started -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnRotate;
                Rotate.performed -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnRotate;
                Rotate.canceled -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnRotate;
                AnyKey.started -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnAnyKey;
                AnyKey.performed -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnAnyKey;
                AnyKey.canceled -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnAnyKey;
                Swap.started -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnSwap;
                Swap.performed -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnSwap;
                Swap.canceled -= m_Wrapper.m_GameplayPadActionsCallbackInterface.OnSwap;
            }
            m_Wrapper.m_GameplayPadActionsCallbackInterface = instance;
            if (instance != null)
            {
                Grow.started += instance.OnGrow;
                Grow.performed += instance.OnGrow;
                Grow.canceled += instance.OnGrow;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Rotate.started += instance.OnRotate;
                Rotate.performed += instance.OnRotate;
                Rotate.canceled += instance.OnRotate;
                AnyKey.started += instance.OnAnyKey;
                AnyKey.performed += instance.OnAnyKey;
                AnyKey.canceled += instance.OnAnyKey;
                Swap.started += instance.OnSwap;
                Swap.performed += instance.OnSwap;
                Swap.canceled += instance.OnSwap;
            }
        }
    }
    public GameplayPadActions @GameplayPad => new GameplayPadActions(this);

    // GameplayMk
    private readonly InputActionMap m_GameplayMk;
    private IGameplayMkActions m_GameplayMkActionsCallbackInterface;
    private readonly InputAction m_GameplayMk_Move;
    private readonly InputAction m_GameplayMk_Look;
    public struct GameplayMkActions
    {
        private PlayerControls m_Wrapper;
        public GameplayMkActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GameplayMk_Move;
        public InputAction @Look => m_Wrapper.m_GameplayMk_Look;
        public InputActionMap Get() { return m_Wrapper.m_GameplayMk; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayMkActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayMkActions instance)
        {
            if (m_Wrapper.m_GameplayMkActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayMkActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayMkActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayMkActionsCallbackInterface.OnMove;
                Look.started -= m_Wrapper.m_GameplayMkActionsCallbackInterface.OnLook;
                Look.performed -= m_Wrapper.m_GameplayMkActionsCallbackInterface.OnLook;
                Look.canceled -= m_Wrapper.m_GameplayMkActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_GameplayMkActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Look.started += instance.OnLook;
                Look.performed += instance.OnLook;
                Look.canceled += instance.OnLook;
            }
        }
    }
    public GameplayMkActions @GameplayMk => new GameplayMkActions(this);
    public interface IGameplayPadActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnAnyKey(InputAction.CallbackContext context);
        void OnSwap(InputAction.CallbackContext context);
    }
    public interface IGameplayMkActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
