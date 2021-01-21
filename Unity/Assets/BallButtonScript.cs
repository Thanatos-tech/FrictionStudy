using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BallButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

	[SerializeField]
	private InfoScript Info;

	[SerializeField]
	private Text Text;


    public void OnPointerEnter(PointerEventData eventData)
	{
		Text.text = "Шарик - объект, который будет совершать колебания. С его помощью будет определяться коэффициент трения качения.";
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
