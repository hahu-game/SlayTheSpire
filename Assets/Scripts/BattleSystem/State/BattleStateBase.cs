using UnityEngine;

//状態の基底クラス
public class BattleStateBase // MonoBehaviourを継承しない　→Unityの性質がない
{
    //誰の状態か：BattleSystemの状態を考える
    protected BattleSystem Owner;

    //コンストラクタ：初期化処理：生成時に呼ばれる
    public BattleStateBase(BattleSystem owner)
    {
        Owner = owner; 
    }

    //　その状態に入った時に呼ばれる
    public virtual void OnEnter()
    {

    }

    //   その状態の毎フレーム更新処理
    public virtual void OnUpdate()
    {

    }

    //   その状態から出るときに呼ばれる
    public virtual void OnExit()
    {

    }


















}
