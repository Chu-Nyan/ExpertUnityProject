using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine) { }


    public override void Enter()
    {
        base.Enter();
    }


    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        if (stateMachine.Movement != Vector2.zero)
        {
            stateMachine.ChangeState(stateMachine.MoveState);
        }
    }


    public override void Exit()
    {
        base.Exit();
    }
}
