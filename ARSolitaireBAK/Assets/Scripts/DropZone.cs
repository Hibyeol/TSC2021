using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

	public void OnPointerEnter(PointerEventData eventData)
	{ //영역 위에 마우스커서가  있다
		Debug.Log("OnPointerEnter");
		if (eventData.pointerDrag == null)
			return;
		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if (d != null)
		{
			d.placeholderParent = this.transform;
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{ // 영역 밖으로 마우스커서 있다
		Debug.Log("OnPointerExit");
		if (eventData.pointerDrag == null)
			return;

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if (d != null && d.placeholderParent == this.transform)
		{
			d.placeholderParent = d.parentToReturnTo;
		}
	}

	public void OnDrop(PointerEventData eventData)
	{ // 놓기
		Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
		if (d != null)
		{
			d.parentToReturnTo = this.transform;
		}

	}
}
