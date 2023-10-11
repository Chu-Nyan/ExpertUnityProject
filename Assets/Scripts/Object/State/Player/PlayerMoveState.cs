using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveState : PlayerGroundState
{
    public PlayerMoveState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        Movement();
    }


    public override void Exit()
    {
        base.Exit();
    }

    protected override void OnMoveKeyInput(InputAction.CallbackContext context)
    {
        base.OnMoveKeyInput(context);
        if (stateMachine.Movement != Vector2.zero)
            return;

        stateMachine.ChangeState(stateMachine.IdleState);

    }
}

