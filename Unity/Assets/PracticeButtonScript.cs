using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PracticeButtonScript : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private InfoScript Info;

    [SerializeField]
    private Text Text;

    [SerializeField]
    private GameObject PracticeInfo;
    [SerializeField]
    private GameObject Calipers;
    [SerializeField]
    private GameObject TurnOnButton;
    [SerializeField]
    private GameObject Column;
    [SerializeField]
    private GameObject Thread;
    [SerializeField]
    private Text CounterText;


    OscillationScript oscillationScript;
    TurnOnButtonScript turnOnButtonScript;
    CalipersScript script;

    public Quaternion defaultRotationOfColumn;
    public Quaternion defaultRotationOfThread;

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
    private GameObject CleanButton;

    CleanButtonScript cleanButtonScript;



    int count = 0;
    public int step;
    public string textDefault;

    public void Start()
    {
        PracticeInfo.SetActive(false);
        script = Calipers.GetComponent<CalipersScript>();
        turnOnButtonScript = TurnOnButton.GetComponent<TurnOnButtonScript>();
        oscillationScript = Thread.GetComponent<OscillationScript>();
        textDefault = r.text;
        step = 1;
        defaultRotationOfColumn = Column.transform.rotation;
        defaultRotationOfThread = Thread.transform.rotation;
        cleanButtonScript = CleanButton.GetComponent<CleanButtonScript>();
    }

    void Update()
    {

        


        if(script.position == 2 && step == 1)
        {
            step++;
        }
        else if(r.text != "-" && step == 2)
        {
            step++;
        }
        else if(turnOnButtonScript.isEnabled && step == 3)
        {
            step++;
        }
        if (step >= 4 && turnOnButtonScript.isEnabled)
        {
            if (Column.transform.localEulerAngles.x == 350 && step == 4)
            {
                step++;
            }
            if(Column.transform.localEulerAngles.x == 350 && step >= 5 && step <= 9)
            {
                if ((int)Thread.transform.localEulerAngles.x == 8 && step == 5)
                {
                    step++;
                }
                else if (oscillationScript.isCoroutine && step == 6)
                {
                    step++;
                }
                else if (oscillationScript.script.counterIsStopped && step == 7)
                {
                    step++;
                }
                else if (n1.text != "-" && step == 8)
                {
                    step++;
                }
            }
            else if (Column.transform.localEulerAngles.x == 340 && step == 9)
            {
                step++;
            }
            else if ((int)Thread.transform.localEulerAngles.x == 8 && step == 10)
            {
                step++;
            }
            else if (CounterText.text.Equals("0") && step == 11)
            {
                step++;
            }
            else if (oscillationScript.isCoroutine && step == 12)
            {
                step++;
            }
            else if (oscillationScript.script.counterIsStopped && step == 13)
            {
                step++;
            }
            else if (n2.text != "-" && step == 14)
            {
                step++;
            }
            else if (Column.transform.localEulerAngles.x == 330 && step == 15)
            {
                step++;
            }
            else if ((int)Thread.transform.localEulerAngles.x == 8 && step == 16)
            {
                step++;
            }
            else if (CounterText.text.Equals("0") && step == 17)
            {
                step++;
            }
            else if (oscillationScript.isCoroutine && step == 18)
            {
                step++;
            }
            else if (oscillationScript.script.counterIsStopped && step == 19)
            {
                step++;
            }
            else if (n3.text != "-" && step == 20)
            {
                step++;
            }
            else if (Column.transform.localEulerAngles.x == 320 && step == 21)
            {
                step++;
            }
            else if ((int)Thread.transform.localEulerAngles.x == 8 && step == 22)
            {
                step++;
            }
            else if (CounterText.text.Equals("0") && step == 23)
            {
                step++;
            }
            else if (oscillationScript.isCoroutine && step == 24)
            {
                step++;
            }
            else if (oscillationScript.script.counterIsStopped && step == 25)
            {
                step++;
            }
            else if (n4.text != "-" && step == 26)
            {
                step++;
            }
        }
        else
        {
            Text.text = "Включите установку.";
        }



        if (step == 1)
        {
            Text.text = "1.Измерьте радиус шарика с помощью штангенциркуля. Для этого нажмите на штангенциркуль, расположенный справа.";
        }
        else if (step == 2)
        {
            Text.text = "2.Запишите радиус шарика(мм) в таблицу.";
        }
        else if (step == 3)
        {
            Text.text = "3.Включите установку.";
        }
        else if (step == 4)
        {
            Text.text = "4.Установите угол наклона колонки 10 градусов.";
        }
        else if (step == 5)
        {
            Text.text = "5.Отклоните шарик от состояния равновесия на 8 градусов.";
        }
        else if (step == 6)
        {
            Text.text = "6.Отпустите шарик.";
        }
        else if (step == 7)
        {
            Text.text = "7.Когда максимальный угол отклонения шарика от состояния равновесия будет равен ~1 градусу, нажмите кнопку 'Стоп'.";
        }
        else if (step == 8)
        {
            Text.text = "8.Внесите количество совершенных колебаний в таблицу.";
        }
        else if (step == 9)
        {
            Text.text = "9.Установите угол наклона колонки 20 градусов.";
        }
        else if (step == 10)
        {
            Text.text = "10.Отклоните шарик от состояния равновесия на 8 градусов.";
        }
        else if (step == 11)
        {
            Text.text = "11.Сбросьте показания счетчика.";
        }
        else if (step == 12)
        {
            Text.text = "12.Отпустите шарик.";
        }
        else if (step == 13)
        {
            Text.text = "13.Когда максимальный угол отклонения шарика от состояния равновесия будет равен ~1 градусу, нажмите кнопку 'Стоп'.";
        }
        else if (step == 14)
        {
            Text.text = "14.Внесите количество совершенных колебаний в таблицу.";
        }
        else if (step == 15)
        {
            Text.text = "15.Установите угол наклона колонки 30 градусов.";
        }
        else if (step == 16)
        {
            Text.text = "16.Отклоните шарик от состояния равновесия на 8 градусов.";
        }
        else if (step == 17)
        {
            Text.text = "17.Сбросьте показания счетчика.";
        }
        else if (step == 18)
        {
            Text.text = "18.Отпустите шарик.";
        }
        else if (step == 19)
        {
            Text.text = "19.Когда максимальный угол отклонения шарика от состояния равновесия будет равен ~1 градусу, нажмите кнопку 'Стоп'.";
        }
        else if (step == 20)
        {
            Text.text = "20.Внесите количество совершенных колебаний в таблицу.";
        }
        else if (step == 21)
        {
            Text.text = "21.Установите угол наклона колонки 40 градусов.";
        }
        else if (step == 22)
        {
            Text.text = "22.Отклоните шарик от состояния равновесия на 8 градусов.";
        }
        else if (step == 23)
        {
            Text.text = "23.Сбросьте показания счетчика.";
        }
        else if (step == 24)
        {
            Text.text = "24.Отпустите шарик.";
        }
        else if (step == 25)
        {
            Text.text = "25.Когда максимальный угол отклонения шарика от состояния равновесия будет равен ~1 градусу, нажмите кнопку 'Стоп'.";
        }
        else if (step == 26)
        {
            Text.text = "26.Внесите количество совершенных колебаний в таблицу.";
        }
        else if (step == 27)
        {
            Text.text = "27.Все измерения сняты. Результаты вычисления коэффициентов трения и погрешности приведены в таблице. Ознакомьтесь с ними, сравните их с табличными значениями и подготовьте вывод о проделанной работе.";

        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        count++;
        if(count%2 == 1)
        {
            PracticeInfo.SetActive(true);
        }
        else if(count%2 == 0)
        {
            PracticeInfo.SetActive(false);
        }

        
    }

}
