using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    public Camera myCamera;
    public PlayerInput InputActions;
    public Transform mesh;

    public float speed = 200;

    private void Start()
    {
        stateMachine = new PlayerStateMachine(this);
    }
}
