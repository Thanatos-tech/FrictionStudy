using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInfoButtonScript : MonoBehaviour
{
    [SerializeField]
    private PanelScript Popup;
    public void OnCloseSettings()
    {
        Popup.Close();       //  ЗАМЕНЯЕМ ТЕКСТ МЕТОДОМ ВСПЛЫВАЮЩЕГО ОКНА. 
    }
}
