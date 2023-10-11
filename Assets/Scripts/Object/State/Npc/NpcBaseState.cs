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
        Debug.Log("진입");

    }

    public virtual void Exit()
    {
        Debug.Log("나가기");
    }

    public virtual void PhysicsUpdate()
    {
    }

    public virtual void Update()
    {
        if (stateMachine.targetPos != null)
        {

        }
    }
}

