using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base (stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    protected override void OnMoveKeyInput(InputAction.CallbackContext context)
    {
        base.OnMoveKeyInput(context);
        if (stateMachine.Movement == Vector2.zero)
            return;

        stateMachine.ChangeState(stateMachine.MoveState);

    }

}
