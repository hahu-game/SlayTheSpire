using UnityEngine;

public class BattlePlayerDrawState : BattleStateBase
{
    public BattlePlayerDrawState(BattleSystem battleSystem) : base(battleSystem)
    {

    }
    public override void OnEnter()
    {
        // Deck‚©‚çƒJ[ƒh‚ğ5–‡ˆø‚­

        for (int i = 0; i < 5; i++)
        {
            CardObj drawCard = Owner.Deck.Draw();
            Owner.Hand.AddCard(drawCard);
        }

        Debug.Log("PlayerDraw‚ÌEnter");
    }
}
