using UnityEngine;

//��Ԃ̊��N���X
public class BattleStateBase // MonoBehaviour���p�����Ȃ��@��Unity�̐������Ȃ�
{
    //�N�̏�Ԃ��FBattleSystem�̏�Ԃ��l����
    protected BattleSystem Owner;

    //�R���X�g���N�^�F�����������F�������ɌĂ΂��
    public BattleStateBase(BattleSystem owner)
    {
        Owner = owner; 
    }

    //�@���̏�Ԃɓ��������ɌĂ΂��
    public virtual void OnEnter()
    {

    }

    //   ���̏�Ԃ̖��t���[���X�V����
    public virtual void OnUpdate()
    {

    }

    //   ���̏�Ԃ���o��Ƃ��ɌĂ΂��
    public virtual void OnExit()
    {

    }


















}
