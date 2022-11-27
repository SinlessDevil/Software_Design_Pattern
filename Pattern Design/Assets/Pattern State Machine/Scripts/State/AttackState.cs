using UnityEngine;
public class AttackState : State
{
    private Player _player;

    public AttackState(Player player)
    {
        _player = player;
    }
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Enter the Attack state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Exit the Attack state");
    }

}
