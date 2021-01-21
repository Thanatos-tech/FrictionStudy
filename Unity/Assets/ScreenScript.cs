using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenScript : MonoBehaviour
{
    [SerializeField]
    private Text text;

    void Start()
    {
        text.text = "";
        
    }

    public void TurnOn()
    {
        text.text = "0";
    }

    void Update()
    {
        
    }
}
