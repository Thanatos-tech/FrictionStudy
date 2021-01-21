using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColumnButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private InfoScript Info;

	[SerializeField]
	private Text Text;

	public void OnPointerEnter(PointerEventData eventData)
	{
		Text.text = "К колонке крепится нить с шариком, а также пластина со шкалой. В ходе выполнения лабораторной работы необходимо менять угол наклона колонки для определения коэффициента трения качения.";
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
