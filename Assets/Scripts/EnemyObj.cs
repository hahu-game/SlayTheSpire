using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyObj : MonoBehaviour,IDropHandler
{
    //�J�[�h���h���b�v�����Ƃ��Ƀ��O���o��


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("�h���b�v���ꂽ");
        // ���J�[�h���ʂ����s
    }
}
