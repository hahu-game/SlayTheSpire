using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deck : MonoBehaviour
{
    //�X�y�[�X���������甭�����鏈���͂Ȃ��Ȃ����̂ŃC���v�b�g�V�X�e���֘A�̓R�����g�A�E�g���Ă���
    //private InputSystem_Actions inputActions;

    [SerializeField] CardObj cardObjPrefab;
    [SerializeField] Hand hand;
    List<CardObj> cards = new List<CardObj>();
    //��邱��
    //1.�R�[�h�𐶐�����@Deck�ɔz�u����
    //2.��D�ɔz��

    //void Awake()
    //{
    //    inputActions = new InputSystem_Actions();
    //}


    public void Setup()
    {
        for (int i = 0; i < 10; i++)
        {
            CardObj cardObj = Spawn();
            cardObj.gameObject.SetActive(false);
            cards.Add(cardObj);
        }
    }

    //void OnEnable()�@//�I�u�W�F�N�g���L�������ꂽ�Ƃ��Ɏ����ŌĂ΂��B
    //{
    //    inputActions.Enable();�@//���̓V�X�e����L��������B
    //    inputActions.createAction.SpaceKey.started += OnSpaceKey;
    //}

    //void OnDisable()�@//�I�u�W�F�N�g�����������ꂽ�Ƃ��Ɏ����ŌĂ΂��B
    //{
    //    inputActions.createAction.SpaceKey.started -= OnSpaceKey;
    //    inputActions.Disable();�@//���̓V�X�e���𖳌�������B
    //}

    //  �X�y�[�X����������ł͂Ȃ��ADrowStates�ɂȂ�����z��悤�ɂ���̂Ŗ���������
    //�@�X�y�[�X���������Ƃ��Ɏ�D�ɃJ�[�h��z��
    //private void OnSpaceKey(InputAction.CallbackContext callbackContext)
    //{
    //    for (int i = 0; i < 5; i++)
    //    {
    //        CardObj drawCard = Draw();
    //        drawCard.transform.SetParent(hand.transform);
    //        drawCard.gameObject.SetActive(true);
    //    }
    // }




    // Update is called once per frame
    //   void Update()
    //   {
    //�@�X�y�[�X���������Ƃ��Ɏ�D�ɃJ�[�h��z��
    //       if (Input.GetKeyDown(KeyCode.Space))
    //       {
    //           CardObj drawCard = Draw();
    //           drawCard.transform.SetParent(hand.transform);
    //           drawCard.gameObject.SetActive(true);
    //       }   
    //   }
    // Deck�̈�ԏォ��J�[�h������
    public CardObj Draw() 
    {
        CardObj cardObj = cards[0];    
        cards.RemoveAt(0);
        return cardObj;
    }


    CardObj Spawn()
    {
        return Instantiate(cardObjPrefab, transform);  //�J�[�h�̐���
    }

}



