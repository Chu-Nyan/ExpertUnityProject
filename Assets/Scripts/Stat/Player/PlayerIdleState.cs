using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base (stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("기본 상태 입장");
    }

    public override void Exit() 
    { 
        base.Exit();
        Debug.Log("기본 상태 나가기");
    }

    protected override void OnMoveKeyInput(InputAction.CallbackContext context)
    {
        base.OnMoveKeyInput(context);
        if (stateMachine.Movement == Vector2.zero)
            return;

        stateMachine.ChangeState(stateMachine.MoveState);

    }

}
