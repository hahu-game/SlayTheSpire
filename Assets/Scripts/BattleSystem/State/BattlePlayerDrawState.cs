using UnityEngine;

public class BattlePlayerDrawState : BattleStateBase
{
    public BattlePlayerDrawState(BattleSystem battleSystem) : base(battleSystem)
    {

    }
    public override void OnEnter()
    {
        // Deck����J�[�h��5������

        for (int i = 0; i < 5; i++)
        {
            CardObj drawCard = Owner.Deck.Draw();
            Owner.Hand.AddCard(drawCard);
        }

        Debug.Log("PlayerDraw��Enter");
    }
}
