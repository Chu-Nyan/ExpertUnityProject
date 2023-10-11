using UnityEngine;

public class NpcBaseState : IState
{
    protected NpcStateMachine stateMachine;

    public NpcBaseState(NpcStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }


    public virtual void Enter()
    {
    }

    public virtual void Exit()
    {
    }

    public virtual void PhysicsUpdate()
    {
    }

    public virtual void Update()
    {
        if (stateMachine.targetPos != null)
        {
            stateMachine.ChangeState(stateMachine.gazeState);
        }
    }
}

