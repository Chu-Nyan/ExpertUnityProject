using System;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player player;

    private Vector2 movement;

    public IState IdleState { get; private set; }
    public IState MoveState { get; private set; }

    public Vector2 Movement 
    {
        get { return movement; }
        set { movement = value; }
    }

    public PlayerStateMachine(Player player)
    {
        this.player = player;
        IdleState = new PlayerIdleState(this);
        MoveState = new PlayerMoveState(this);

        ChangeState(IdleState);
    }
}

