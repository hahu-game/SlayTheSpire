using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    List<CardObj> cards = new List<CardObj>();

    public void AddCard(CardObj cardObj)
    {
        cards.Add(cardObj);
        // 親をHandにする
        cardObj.transform.SetParent(transform); //そのコードを実行しているクラス（Hand）がアタッチされているゲームオブジェクトが親になる。
        cardObj.gameObject.SetActive(true);
        ArrangeCards();
        cardObj.OnEndDragAction += ArrangeCards; //登録しておく。OnEndDragAction（マウスカーソルが離れたとき）にする挙動は、ArrangeCardsだよ。
                                                 //+=にしておくと複数登録できる。１個だけ登録するだけなら=でもいい。
    }

    // 手札に加えられたカードを整列させる

    void ArrangeCards()
    {
        for (int i = 0; i < cards.Count; i++)
        {
            // 中心を0にしたい。手札が５枚だったら３枚目、４枚だったら2.5枚目が中心にする。
            float center = (cards.Count - 1) / 2.0f;
            // カードの感覚
            float interval = 100.0f;
            // カードの位置
            float x = (i - center) * interval;
            cards[i].transform.localPosition = new Vector3(x, 0, 0);
        }

        // カードをドラッグから離したときに（終了時に）、カードを整列させる。

    }
}


