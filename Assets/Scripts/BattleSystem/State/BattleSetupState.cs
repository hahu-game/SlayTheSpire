using UnityEngine;

public class BattleSetupState : BattleStateBase
{
    //  �E1.�����Fsetup :Deck�����
    public BattleSetupState(BattleSystem battleSystem) : base(battleSystem)
    {

    }
    public override void OnEnter()
    {
        Debug.Log("Setup��Enter");
        Owner.Deck.Setup();

        Owner.ChangeState(Owner.PlayerDrawState);
    }






}
