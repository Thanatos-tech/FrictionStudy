using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CleanButtonScript : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private Text r;
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
    [SerializeField]
    private GameObject Column;
    [SerializeField]
    private GameObject Thread;

    [SerializeField]
    private GameObject TurnOnButton;

    [SerializeField]
    private GameObject PracticeButton;


    public int countOfCleaning = 0;

    PracticeButtonScript practiceButtonScript;
    TurnOnButtonScript turnOnButtonScript;
    ColumnRotationScript columnRotationScript;

    private void Start()
    {
        practiceButtonScript = PracticeButton.GetComponent<PracticeButtonScript>();
        turnOnButtonScript = TurnOnButton.GetComponent<TurnOnButtonScript>();
        columnRotationScript = Column.GetComponent<ColumnRotationScript>();
    }

    

    public void OnPointerDown(PointerEventData eventData)
    {
        r.text = "-";
        n1.text = "-";
        n2.text = "-";
        n3.text = "-";
        n4.text = "-";
        uk1.text = "-";
        uk2.text = "-";
        uk3.text = "-";
        uk4.text = "-";
        avguk.text = "-";
        deltauk.text = "-";
        Eu.text = "-";
        practiceButtonScript.step = 1;
        Column.transform.rotation = practiceButtonScript.defaultRotationOfColumn;
        Thread.transform.rotation = practiceButtonScript.defaultRotationOfThread;
        turnOnButtonScript.ForClean();
        columnRotationScript.count = 0;
        if((int)Column.transform.localEulerAngles.x == 350)
        {
            Column.transform.Rotate(new Vector3(10,0,0));
        }
        else if ((int)Column.transform.localEulerAngles.x == 340)
        {
            Column.transform.Rotate(new Vector3(20, 0, 0));
        }
        else if ((int)Column.transform.localEulerAngles.x == 330)
        {
            Column.transform.Rotate(new Vector3(30, 0, 0));
        }
        else if ((int)Column.transform.localEulerAngles.x == 320)
        {
            Column.transform.Rotate(new Vector3(40, 0, 0));
        }
    }
}
