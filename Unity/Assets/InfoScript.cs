using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
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
