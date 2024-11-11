using UnityEngine;

public class DeathState : IState
{
    PlayerController player;

    //생성자 
    public DeathState(PlayerController player)
    {
        this.player = player;
    }
    public void Enter()
    {
        player.GetComponent<Animator>().SetTrigger("Death");
    }

    public void Excute()
    {

    }

    public void Exit()
    {

    }
}
