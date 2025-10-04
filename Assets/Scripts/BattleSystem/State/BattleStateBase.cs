using UnityEngine;

//��Ԃ̊��N���X
public class BattleStateBase // MonoBehaviour���p�����Ȃ��@��Unity�̐������Ȃ�
{
    //�N�̏�Ԃ��FBattleSystem�̏�Ԃ��l����
    protected BattleSystem Owner;

    //�R���X�g���N�^�F�����������F�������ɌĂ΂��B
    //�N���X���Ɠ������O�̃��\�b�h�Ȃ̂ŃR���X�g���N�^������Ă���B
    //�R���X�g���N�^�́A�I�u�W�F�N�g�������ɕK�����s�������ʂȃ��\�b�h�B
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
