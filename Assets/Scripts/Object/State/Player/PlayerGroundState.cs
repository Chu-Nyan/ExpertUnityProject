
using UnityEngine;

public class PlayerGroundState : PlayerBaseState
{
    public PlayerGroundState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        if (stateMachine.player.rigid.velocity.y <= Physics.gravity.y * Time.fixedDeltaTime)
        {
            stateMachine.ChangeState(stateMachine.FallState);
        }
    }


    public override void Enter()
    {
        base.Enter();
        AddKeyMap();
    }


    public override void Exit() 
    {
        base.Exit();
        DelKeyMap();
    }
}
