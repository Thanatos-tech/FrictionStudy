using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlastineButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private InfoScript Info;

	[SerializeField]
	private Text Text;

	public void OnPointerEnter(PointerEventData eventData)
	{
		Text.text = "На пластине располагается шкала. Пластина необходима для создания силы трения в момент колебаний шарика.";
		Info.Open();
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		Info.Close();
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
