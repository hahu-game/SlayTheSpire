using UnityEngine;

public class BattleSetupState : BattleStateBase
{
    //  E1.€”õFsetup :Deck‚ğì‚é
    public BattleSetupState(BattleSystem battleSystem) : base(battleSystem)
    {

    }
    public override void OnEnter()
    {
        Debug.Log("Setup‚ÌEnter");
        Owner.Deck.Setup();

        Owner.ChangeState(Owner.PlayerDrawState);
    }






}
