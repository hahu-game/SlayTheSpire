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

    public UnityAction OnEndDragAction; //�h���b�O�I�����Ɏ��s�������֐���o�^�ł���ϐ�

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