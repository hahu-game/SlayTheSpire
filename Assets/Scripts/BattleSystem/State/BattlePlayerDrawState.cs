using UnityEngine;

public class BattlePlayerDrawState : BattleStateBase
{
    public BattlePlayerDrawState(BattleSystem battleSystem) : base(battleSystem)
    {

    }
    public override void OnEnter()
    {
        Debug.Log("PlayerDraw��Enter");
    }
}
