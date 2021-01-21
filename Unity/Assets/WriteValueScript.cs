using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WriteValueScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject writeButton;
    [SerializeField]
    private InputField inputValue;
    [SerializeField]
    private GameObject practiceButton;
    [SerializeField]
    private Text r;
    [SerializeField]
    private Text b1;
    [SerializeField]
    private Text b2;
    [SerializeField]
    private Text b3;
    [SerializeField]
    private Text b4;
    [SerializeField]
    private Text n1;
    [SerializeField]
    private Text n2;
    [SerializeField]
    private Text n3;
    [SerializeField]
    private Text n4;
    [SerializeField]
    private Text uk1;
    [SerializeField]
    private Text uk2;
    [SerializeField]
    private Text uk3;
    [SerializeField]
    private Text uk4;
    [SerializeField]
    private Text avguk;
    [SerializeField]
    private Text deltauk;
    [SerializeField]
    private Text Eu;

    PracticeButtonScript script;

    double a0 = 0.14;
    double an = 0.017;
    double rToDouble;
    double n1ToDouble;
    double n2ToDouble;
    double n3ToDouble;
    double n4ToDouble;
    double b1ToDouble = 10;
    double b2ToDouble = 20;
    double b3ToDouble = 30;
    double b4ToDouble = 40;
    double uk1Value;
    double uk2Value;
    double uk3Value;
    double uk4Value;
    double avgukValue;
    double deltaukValue;
    double EuValue;





    private void Start()
    {
        script = practiceButton.GetComponent<PracticeButtonScript>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (script.step == 2 && r.text == "-")
        {
            r.text = inputValue.text;
            rToDouble = Convert.ToDouble(inputValue.text);
            inputValue.text = "";
        }
        if (script.step == 8 && n1.text == "-" && uk1.text == "-")
        {
            n1.text = inputValue.text;
            n1ToDouble = Convert.ToDouble(inputValue.text);
            inputValue.text = "";
            uk1Value = Math.Abs(Math.Round((rToDouble * ((a0 - an) / (4 * n1ToDouble)) * (1 / Math.Tan(b1ToDouble))), 4)) / 1.5f;
            uk1.text = uk1Value.ToString();
        }
        if (script.step == 14 && n2.text == "-")
        {
            n2.text = inputValue.text;
            n2ToDouble = Convert.ToDouble(inputValue.text);
            inputValue.text = "";
            uk2Value = Math.Abs(Math.Round((rToDouble * ((a0 - an) / (4 * n2ToDouble)) * (1 / Math.Tan(b2ToDouble))), 4)) * 2.5f;
            uk2.text = uk2Value.ToString();
        }
        if (script.step == 20 && n3.text == "-")
        {
            n3.text = inputValue.text;
            n3ToDouble = Convert.ToDouble(inputValue.text);
            inputValue.text = "";
            uk3Value = Math.Abs(Math.Round((rToDouble * ((a0 - an) / (4 * n3ToDouble)) * (1 / Math.Tan(b3ToDouble))), 4)) * 2.5f;
            uk3.text = uk3Value.ToString();
        }
        if (script.step == 26 && n4.text == "-")
        {
            n4.text = inputValue.text;
            n4ToDouble = Convert.ToDouble(inputValue.text);
            inputValue.text = "";
            uk4Value = Math.Abs(Math.Round((rToDouble * ((a0 - an) / (4 * n4ToDouble)) * (1 / Math.Tan(b4ToDouble))), 4)) / 3;
            uk4.text = uk4Value.ToString();
            avgukValue = Math.Round((uk1Value + uk2Value + uk3Value + uk4Value) / 4, 4);
            avguk.text = avgukValue.ToString();
            deltaukValue = Math.Round(2.4 * Math.Sqrt((1 / 12) * (Math.Pow((uk1Value - avgukValue), 2)) + Math.Pow((uk2Value - avgukValue), 2) + Math.Pow((uk3Value - avgukValue), 2) + Math.Pow((uk4Value - avgukValue), 2)), 4);
            deltauk.text = deltaukValue.ToString();
            EuValue = Math.Abs(0.01 - avgukValue) / avgukValue;
            Eu.text = EuValue.ToString();
        }
    }
}
