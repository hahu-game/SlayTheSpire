using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deck : MonoBehaviour
{
    private InputSystem_Actions inputActions;

    [SerializeField] CardObj cardObjPrefab;
    [SerializeField] Hand hand;
    List<CardObj> cards = new List<CardObj>();
    //やること
    //1.コードを生成する　Deckに配置する
    //2.手札に配る

    void Awake()
    {
        inputActions = new InputSystem_Actions();

        for (int i = 0; i < 10; i++)
        {
            CardObj cardObj = Spawn();
            cardObj.gameObject.SetActive(false);
            cards.Add(cardObj);
        }
    }

    void OnEnable()　//オブジェクトが有効化されたときに自動で呼ばれる。
    {
        inputActions.Enable();　//入力システムを有効化する。
        inputActions.createAction.SpaceKey.started += OnSpaceKey;
    }

    void OnDisable()　//オブジェクトが無効化されたときに自動で呼ばれる。
    {
        inputActions.createAction.SpaceKey.started -= OnSpaceKey;　
        inputActions.Disable();　//入力システムを無効化する。
    }


    //　スペースを押したときに手札にカードを配る
    private void OnSpaceKey(InputAction.CallbackContext callbackContext)
    {
        for (int i = 0; i < 5; i++)
        {
            CardObj drawCard = Draw();
            drawCard.transform.SetParent(hand.transform);
            drawCard.gameObject.SetActive(true);
        }


    }




    // Update is called once per frame
 //   void Update()
 //   {
        //　スペースを押したときに手札にカードを配る
 //       if (Input.GetKeyDown(KeyCode.Space))
 //       {
 //           CardObj drawCard = Draw();
 //           drawCard.transform.SetParent(hand.transform);
 //           drawCard.gameObject.SetActive(true);
 //       }   
 //   }
    // Deckの一番上からカードを引く
    private CardObj Draw() 
    {
        CardObj cardObj = cards[0];    
        cards.RemoveAt(0);
        return cardObj;
    }


CardObj Spawn()
    {
        return Instantiate(cardObjPrefab, transform);  //カードの生成
    }

}



