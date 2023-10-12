using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputActions inputActions;
    public PlayerInputActions.KeyBoardActions KeyBoardActions;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        KeyBoardActions = inputActions.KeyBoard;
        inputActions.Enable();
    }
}
