using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    public Camera mainCamera;
    public PlayerInput InputActions;
    public Transform mesh;
    public Rigidbody rigid;

    public float speed = 200;

    private void Start()
    {
        stateMachine = new PlayerStateMachine(this);
    }
}
