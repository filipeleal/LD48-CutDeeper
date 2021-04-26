// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""691eda96-cbdc-4a65-8543-2d4e73229591"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""324f058d-b263-4c81-b4b5-ae8742d7cc9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4facd32d-98a5-4c33-a2a6-1c2b53e537b5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""a4d2966e-4696-45dd-9285-f1a025f5bdfb"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""2feb3acf-28db-4c2b-8560-4fa6e0b88378"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""36770bef-6028-4278-8fe0-537ad1f23d31"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""3c909612-d8d5-4f81-9020-7960a1172851"",
            ""actions"": [
                {
                    ""name"": ""NewGame"",
                    ""type"": ""Button"",
                    ""id"": ""5e88665c-e9b3-444e-9ad8-de1967a81f1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f854962c-3c34-491b-80e5-381387b70cff"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NewGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Quit"",
            ""id"": ""3fa6243c-3ae7-44ac-be73-0a358a27f82c"",
            ""actions"": [
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""df36f660-ba22-4d07-a044-93f335ab9b9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""19ded37a-0fbe-4a29-b2ca-ec35e337c920"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Attack = m_Player1.FindAction("Attack", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Attack = m_Player2.FindAction("Attack", throwIfNotFound: true);
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_NewGame = m_Game.FindAction("NewGame", throwIfNotFound: true);
        // Quit
        m_Quit = asset.FindActionMap("Quit", throwIfNotFound: true);
        m_Quit_Quit = m_Quit.FindAction("Quit", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Attack;
    public struct Player1Actions
    {
        private @PlayerActions m_Wrapper;
        public Player1Actions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Player1_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Attack;
    public struct Player2Actions
    {
        private @PlayerActions m_Wrapper;
        public Player2Actions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Player2_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_NewGame;
    public struct GameActions
    {
        private @PlayerActions m_Wrapper;
        public GameActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NewGame => m_Wrapper.m_Game_NewGame;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @NewGame.started -= m_Wrapper.m_GameActionsCallbackInterface.OnNewGame;
                @NewGame.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnNewGame;
                @NewGame.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnNewGame;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NewGame.started += instance.OnNewGame;
                @NewGame.performed += instance.OnNewGame;
                @NewGame.canceled += instance.OnNewGame;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Quit
    private readonly InputActionMap m_Quit;
    private IQuitActions m_QuitActionsCallbackInterface;
    private readonly InputAction m_Quit_Quit;
    public struct QuitActions
    {
        private @PlayerActions m_Wrapper;
        public QuitActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Quit => m_Wrapper.m_Quit_Quit;
        public InputActionMap Get() { return m_Wrapper.m_Quit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QuitActions set) { return set.Get(); }
        public void SetCallbacks(IQuitActions instance)
        {
            if (m_Wrapper.m_QuitActionsCallbackInterface != null)
            {
                @Quit.started -= m_Wrapper.m_QuitActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_QuitActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_QuitActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_QuitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public QuitActions @Quit => new QuitActions(this);
    public interface IPlayer1Actions
    {
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnNewGame(InputAction.CallbackContext context);
    }
    public interface IQuitActions
    {
        void OnQuit(InputAction.CallbackContext context);
    }
}
