using UnityEngine;

public class IdleState : IState
{
    PlayerController player;

    //생성자 
    public IdleState(PlayerController player)
    {
        this.player = player;
    }


    public void Enter()
    {
        player.GetComponent<Animator>().SetTrigger("Idle");
    }


    public void Excute()
    {
        
    }

    public void Exit()
    {
        
    }
}
