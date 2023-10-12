using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallState : PlayerBaseState
{
    public PlayerFallState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    private readonly float waitTImeValue = 0.5f;

    private float waitTIme;


    public override void Enter()
    {
        base.Enter();
        waitTIme = waitTImeValue;
    }


    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        if (stateMachine.player.rigid.velocity.y == 0)
        {
            waitTIme -= Time.fixedDeltaTime;

            if (waitTIme <= 0)
                stateMachine.ChangeState(stateMachine.IdleState);
        }
        else
        {
            waitTIme = waitTImeValue;
        }
    }


    public override void Exit()
    {
        base.Exit();
    }
}
