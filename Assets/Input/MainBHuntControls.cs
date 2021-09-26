// GENERATED AUTOMATICALLY FROM 'Assets/Input/MainBHuntControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GameSE.BHunt.Input
{
    public class @MainBHuntControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MainBHuntControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainBHuntControls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""53e2a5af-6a82-46ec-b5bc-b80763a9b980"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4166892e-bcd5-4f1b-b15e-83c8026f0961"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""44d95369-1417-4417-a305-ba58ec9a61fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""3ff58e96-bc02-4d9d-a089-1ff90af5fd19"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ebac8cf4-8d35-437c-906b-604d6b0ccf52"",
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
                    ""id"": ""e24b9cb2-90e5-457f-9bf0-1a9d3b612a4b"",
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
                    ""id"": ""d7d06a3c-e84d-401e-a2f6-37fb2aa5f7ad"",
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
                    ""id"": ""5e16e5a2-64ed-4265-b8fb-532f4fb60ed7"",
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
                    ""id"": ""6044ed37-3b68-4363-9b26-4f899156aca9"",
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
                    ""id"": ""e4b34bf4-1a87-4592-ab78-f67d15e52300"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4492d76d-65c6-4b6f-ab47-92becd6b3fff"",
                    ""path"": ""<Mouse>/delta"",
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
            // Main
            m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
            m_Main_Move = m_Main.FindAction("Move", throwIfNotFound: true);
            m_Main_Aim = m_Main.FindAction("Aim", throwIfNotFound: true);
            m_Main_Look = m_Main.FindAction("Look", throwIfNotFound: true);
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

        // Main
        private readonly InputActionMap m_Main;
        private IMainActions m_MainActionsCallbackInterface;
        private readonly InputAction m_Main_Move;
        private readonly InputAction m_Main_Aim;
        private readonly InputAction m_Main_Look;
        public struct MainActions
        {
            private @MainBHuntControls m_Wrapper;
            public MainActions(@MainBHuntControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Main_Move;
            public InputAction @Aim => m_Wrapper.m_Main_Aim;
            public InputAction @Look => m_Wrapper.m_Main_Look;
            public InputActionMap Get() { return m_Wrapper.m_Main; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
            public void SetCallbacks(IMainActions instance)
            {
                if (m_Wrapper.m_MainActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMove;
                    @Aim.started -= m_Wrapper.m_MainActionsCallbackInterface.OnAim;
                    @Aim.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnAim;
                    @Aim.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnAim;
                    @Look.started -= m_Wrapper.m_MainActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnLook;
                }
                m_Wrapper.m_MainActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Aim.started += instance.OnAim;
                    @Aim.performed += instance.OnAim;
                    @Aim.canceled += instance.OnAim;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                }
            }
        }
        public MainActions @Main => new MainActions(this);
        public interface IMainActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnAim(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
        }
    }
}
