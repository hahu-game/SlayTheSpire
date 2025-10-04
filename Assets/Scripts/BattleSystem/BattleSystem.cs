using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    //　フェーズ（バトルの状態）の管理
    //  ・1.準備：setup :Deckを作る
    //  ・2.Playerのドローフェーズ：Deckからカードを5枚引く
    //  ・3.Playerのカード選択のフェーズ
    //  ・4.Playerのカード効果のフェーズ
    //  ・5.Enemyのフェーズ

    //　これらをステートパターンで管理する
    //  利点：各フェーズの処理がクラスに分かれているので、編集がしやすい

    //  どうやって実装するの？
    //  ・状態の基底クラスを作る
    //  ・それぞれの暮らすを作る
    //  ・状態の切り替えを行う関数を作る

    BattleSetupState setupState;
    BattlePlayerDrawState playerDrawState;
    BattleCardSelectionState cardSelectionState;
    BattleStateBase currentState;

    //PlayerDrawStateなどを外部クラスに対して公開だけしている。（読み取り専用）
    //外部クラスの中でChangeStateを呼び出すがそのときの変数で、これらを指定する必要があるため。
    //あくまで読み取り専用なので、PlayerDrawStateの中身をBattlePlayerStatesの中で編集などはできない。（保守性が高い）
    public BattlePlayerDrawState PlayerDrawState { get => playerDrawState; } 

    private void Start()
    {
        Debug.Log("BattleSystem Start");
        setupState = new BattleSetupState(this);　　　　　　　　　 //ownerにthis(自分自身)を入れている
        playerDrawState = new BattlePlayerDrawState(this);
        cardSelectionState = new BattleCardSelectionState(this);

        ChangeState(setupState);

    }

    //状態の切り替え
    public void ChangeState(BattleStateBase newState)
    {
        currentState = newState;
        currentState.OnEnter();
    }








}
