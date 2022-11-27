using UnityEngine;
public class IdileState : State
{
    private Player _player;

    public IdileState(Player player)
    {
        _player = player;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Enter the Idile state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Exit the Idile state");
    }
}
