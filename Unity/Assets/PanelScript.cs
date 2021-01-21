using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
    public void Open()
    {
        gameObject.SetActive(true);  //   АКТИВАЦИЯ ОКНА.  
    }
    public void Close()
    {
        gameObject.SetActive(false); //  Деактивация окна.  
    }

}
