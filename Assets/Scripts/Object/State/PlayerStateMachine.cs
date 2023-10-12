using System;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player player;

    public IState IdleState { get; private set; }
    public IState MoveState { get; private set; }
    public IState FallState { get; private set; }

    public Vector2 Movement { get; set; }


    public PlayerStateMachine(Player player)
    {
        this.player = player;
        IdleState = new PlayerIdleState(this);
        MoveState = new PlayerMoveState(this);
        FallState = new PlayerFallState(this);

        ChangeState(IdleState);
    }
}

