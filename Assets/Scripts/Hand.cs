using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    List<CardObj> cards = new List<CardObj>();

    public void AddCard(CardObj cardObj)
    {
        cards.Add(cardObj);
        // �e��Hand�ɂ���
        cardObj.transform.SetParent(transform); //���̃R�[�h�����s���Ă���N���X�iHand�j���A�^�b�`����Ă���Q�[���I�u�W�F�N�g���e�ɂȂ�B
        cardObj.gameObject.SetActive(true);
        ArrangeCards();
        cardObj.OnEndDragAction += ArrangeCards; //�o�^���Ă����BOnEndDragAction�i�}�E�X�J�[�\�������ꂽ�Ƃ��j�ɂ��鋓���́AArrangeCards����B
                                                 //+=�ɂ��Ă����ƕ����o�^�ł���B�P�����o�^���邾���Ȃ�=�ł������B
    }

    // ��D�ɉ�����ꂽ�J�[�h�𐮗񂳂���

    void ArrangeCards()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            // ���S��0�ɂ������B��D���T����������R���ځA�S����������2.5���ڂ����S�ɂ���B
            float center = (cards.Count - 1) / 2.0f;
            // �J�[�h�̊��o
            float interval = 100.0f;
            // �J�[�h�̈ʒu
            float x = (i - center) * interval;
            cards[i].transform.localPosition = new Vector3(x, 0, 0);
        }

        // �J�[�h���h���b�O���痣�����Ƃ��Ɂi�I�����Ɂj�A�J�[�h�𐮗񂳂���B

    }
}


