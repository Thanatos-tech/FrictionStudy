using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropdownPanelScript : MonoBehaviour, IPointerExitHandler
{
    [SerializeField]
    private Button button1;
    [SerializeField]
    private Button button2;
    [SerializeField]
    private Button button3;
    [SerializeField]
    private Button button4;
    [SerializeField]
    private Button button5;
    [SerializeField]
    private Button button6;


    BallButtonScript ballButton;
    ThreadButtonScript threadButton;
    ColumnButtonScript columnButton;
    ScaleButtonScript scaleButton;
    PlastineButtonScript plastineButton;
    CounterButtonScript counterButton;

    private void Start()
    {
        ballButton = button1.GetComponent<BallButtonScript>();
        threadButton = button2.GetComponent<ThreadButtonScript>();
        columnButton = button3.GetComponent<ColumnButtonScript>();
        scaleButton = button4.GetComponent<ScaleButtonScript>();
        plastineButton = button5.GetComponent<PlastineButtonScript>();
        counterButton = button6.GetComponent<CounterButtonScript>();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ballButton.Close();
        threadButton.Close();
        columnButton.Close();
        scaleButton.Close();
        plastineButton.Close();
        counterButton.Close();
    }
}
