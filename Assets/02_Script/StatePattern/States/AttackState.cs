using UnityEngine;

public class AttackState : IState
{
    PlayerController player;

    //생성자 
    public AttackState(PlayerController player)
    {
        this.player = player;
    }

    public void Enter()
    {
        player.GetComponent<Animator>().SetTrigger("Attack");
    }

    public void Excute()
    {

    }

    public void Exit()
    {

    }
}
