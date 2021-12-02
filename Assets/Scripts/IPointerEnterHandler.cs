using UnityEngine.EventSystems;

internal interface IPointerEnterHandler
{
    void OnPointerEnter(PointerEventData eventData);
    void OnPointerExit(PointerEventData eventData);
}