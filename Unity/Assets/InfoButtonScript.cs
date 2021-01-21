using UnityEngine;
using UnityEngine.UI; 				//  ИМПОРТ МОДУЛЯ ДЛЯ РАБОТЫ С КОДОМ UI 
using UnityEngine.EventSystems;
using System.Collections;
public class InfoButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private PanelScript Popup;
    void Start()
    {
        Popup.Close(); //  ЗАКРЫВАЕМ ВСПЛЫВАЮЩЕЕ ОКНО В НАЧАЛЕ ИГРЫ. 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Popup.Open();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Popup.Close();
    }
}

