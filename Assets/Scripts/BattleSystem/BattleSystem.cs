using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    //�@�t�F�[�Y�i�o�g���̏�ԁj�̊Ǘ�
    //  �E1.�����Fsetup :Deck�����
    //  �E2.Player�̃h���[�t�F�[�Y�FDeck����J�[�h��5������
    //  �E3.Player�̃J�[�h�I���̃t�F�[�Y
    //  �E4.Player�̃J�[�h���ʂ̃t�F�[�Y
    //  �E5.Enemy�̃t�F�[�Y

    //�@�������X�e�[�g�p�^�[���ŊǗ�����
    //  ���_�F�e�t�F�[�Y�̏������N���X�ɕ�����Ă���̂ŁA�ҏW�����₷��

    //  �ǂ�����Ď�������́H
    //  �E��Ԃ̊��N���X�����
    //  �E���ꂼ��̕�炷�����
    //  �E��Ԃ̐؂�ւ����s���֐������

    BattleSetupState setupState;
    BattlePlayerDrawState playerDrawState;
    BattleCardSelectionState cardSelectionState;
    BattleStateBase currentState;

    //PlayerDrawState�Ȃǂ��O���N���X�ɑ΂��Č��J�������Ă���B�i�ǂݎ���p�j
    //�O���N���X�̒���ChangeState���Ăяo�������̂Ƃ��̕ϐ��ŁA�������w�肷��K�v�����邽�߁B
    //�����܂œǂݎ���p�Ȃ̂ŁAPlayerDrawState�̒��g��BattlePlayerStates�̒��ŕҏW�Ȃǂ͂ł��Ȃ��B�i�ێ琫�������j
    public BattlePlayerDrawState PlayerDrawState { get => playerDrawState; } 

    private void Start()
    {
        Debug.Log("BattleSystem Start");
        setupState = new BattleSetupState(this);�@�@�@�@�@�@�@�@�@ //owner��this(�������g)�����Ă���
        playerDrawState = new BattlePlayerDrawState(this);
        cardSelectionState = new BattleCardSelectionState(this);

        ChangeState(setupState);

    }

    //��Ԃ̐؂�ւ�
    public void ChangeState(BattleStateBase newState)
    {
        currentState = newState;
        currentState.OnEnter();
    }








}
