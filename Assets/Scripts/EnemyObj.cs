using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour,IDropHandler
{
    //カードをドロップしたときにログを出す


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ドロップされた");
        // ↓カード効果を実行
    }
}
