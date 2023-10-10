using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveState : PlayerGroundState
{
    public PlayerMoveState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("움직임 상태 입장");
    }

    public override void PhysicsUpdate()
    {
        Debug.Log("움직임 상태 업데이트");
        base.PhysicsUpdate();
        Movement();
    }


    public override void Exit()
    {
        base.Exit();
        Debug.Log("움직임 상태 나가기");
    }

    protected override void OnMoveKeyInput(InputAction.CallbackContext context)
    {
        base.OnMoveKeyInput(context);
        if (stateMachine.Movement != Vector2.zero)
            return;

        stateMachine.ChangeState(stateMachine.IdleState);

    }
}

