using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InstallationButtonScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject thread;
    [SerializeField]
    private GameObject column;
    [SerializeField]
    private GameObject scale;
    [SerializeField]
    private GameObject plastine;
    [SerializeField]
    private GameObject screen;

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



    MaterialChanger changer1;
    MaterialChanger changer2;
    MaterialChanger changer3;
    MaterialChanger changer4;
    MaterialChanger changer5;
    MaterialChanger changer6;

    BallButtonScript ballButton;
    ThreadButtonScript threadButton;
    ColumnButtonScript columnButton;
    ScaleButtonScript scaleButton;
    PlastineButtonScript plastineButton;
    CounterButtonScript counterButton;

    public void Start()
    {
        changer1 = ball.GetComponent<MaterialChanger>();
        changer2 = thread.GetComponent<MaterialChanger>();
        changer3 = column.GetComponent<MaterialChanger>();
        changer4 = scale.GetComponent<MaterialChanger>();
        changer5 = plastine.GetComponent<MaterialChanger>();
        changer6 = screen.GetComponent<MaterialChanger>();

        ballButton = button1.GetComponent<BallButtonScript>();
        threadButton = button2.GetComponent<ThreadButtonScript>();
        columnButton = button3.GetComponent<ColumnButtonScript>();
        scaleButton = button4.GetComponent<ScaleButtonScript>();
        plastineButton = button5.GetComponent<PlastineButtonScript>();
        counterButton = button6.GetComponent<CounterButtonScript>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        changer1.BackMaterials();
        changer2.BackMaterials();
        changer3.BackMaterials();
        changer4.BackMaterials();
        changer5.BackMaterials();
        changer6.BackMaterials();
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        ballButton.Open();
        threadButton.Open();
        columnButton.Open();
        scaleButton.Open();
        plastineButton.Open();
        counterButton.Open();
    }
    
}
