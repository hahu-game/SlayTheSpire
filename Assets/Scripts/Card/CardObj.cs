using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class CardObj : MonoBehaviour, IDragHandler, IEndDragHandler,IBeginDragHandler
{
    [SerializeField] Text nameText;
    [SerializeField] Text descriptionText;
    [SerializeField] Image icon;
    [SerializeField] Text costText;

    CanvasGroup canvasGroup;

    public UnityAction OnEndDragAction; //ドラッグ終了時に実行したい関数を登録できる変数

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        OnEndDragAction?.Invoke();
    }

}