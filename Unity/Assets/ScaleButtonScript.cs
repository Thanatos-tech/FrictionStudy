using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScaleButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private GameObject Info;

	[SerializeField]
	private Text Text;
    public void OnPointerEnter(PointerEventData eventData)
	{
		Text.text = "Шкала необходима для определения угла отклонения шарика.";
		Info.SetActive(true);
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		Info.SetActive(false);
	}

	public void Open()
	{
		gameObject.SetActive(true);  //   АКТИВАЦИЯ ОКНА.  
	}
	public void Close()
	{
		gameObject.SetActive(false); //  Деактивация окна.  
	}
}
