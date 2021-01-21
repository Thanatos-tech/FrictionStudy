using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OscillationScript : MonoBehaviour
{
    [SerializeField]
    private GameObject stopButton;

    public StopButtonScript script;

    [SerializeField]
    private GameObject gameObject;

    [SerializeField]
    private Text maxDeflectionAngle;

    [SerializeField]
    private GameObject column;

    [SerializeField]
    private Text text;

    

    

    Quaternion defaultPosition;

    Coroutine a;

    bool flag = true;
    public bool isCoroutine = false;
    float lowLimit = 8.0f;
    float lowLimitt;
    int angle;
    public int count;
    float speed = 0.15f;
    float newSpeed = 0.15f;
    int k = -1;
    float difference;



    private void Start()
    {
        script = stopButton.GetComponent<StopButtonScript>();
        
    }


    public void Rotation()
    {
        defaultPosition = gameObject.transform.rotation;
        gameObject.transform.Rotate(new Vector3(8, 0, 0));
        if(gameObject.transform.localEulerAngles.x < 8)
        {
            gameObject.transform.Rotate(new Vector3(0.1f, 0, 0));
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Rotation();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            Coroutine();
        }


        if (isCoroutine)
        {
            if (angle == 350)
            {
                speed = 0.2f;
            }
            else if (angle == 340)
            {
                speed = 0.19f;
            }
            else if (angle == 330)
            {
                speed = 0.18f;
            }
            else if (angle == 320)
            {
                speed = 0.17f;
            }
            a = StartCoroutine("Oscillation");
        }
        else
        {
            maxDeflectionAngle.text = "0";

        }
    }


    public void Coroutine()
    {
        maxDeflectionAngle.text = "0";
        angle = (int)column.transform.localEulerAngles.x;
        if(angle == 350)
        {
            difference = 0.4f;
        }
        else if (angle == 340)
        {
            difference = 0.5f;
        }
        else if (angle == 330)
        {
            difference = 0.8f;
        }
        else if (angle == 320)
        {
            difference = 1;
        }
        lowLimit = 8.0f;
        lowLimitt = lowLimit - difference;
        isCoroutine = true;
    }


    public IEnumerator Oscillation()
    {
        for (; ; )
        {

            if (lowLimit >= 7 && lowLimit <= 8)
            {
                speed *= 1.0f;
            }
            else if (lowLimit >= 6 && lowLimit < 7)
            {
                speed *= 0.875f;
            }
            else if (lowLimit >= 5 && lowLimit < 6)
            {
                speed *= 0.75f;
            }
            else if (lowLimit >= 4 && lowLimit < 5)
            {
                speed *= 0.625f;
            }
            else if (lowLimit >= 3 && lowLimit < 4)
            {
                speed *= 0.5f;
            }
            else if (lowLimit >= 2 && lowLimit < 3)
            {
                speed *= 0.375f;
            }
            else if (lowLimit >= 1 && lowLimit < 2)
            {
                speed *= 0.25f;
            }
            else if (lowLimit > 0 && lowLimit < 1)
            {
                speed *= 0.125f;
            }
            else if (lowLimit <= 0 || lowLimitt <= 0)
            {
                script.counterIsStopped = false;
                StopCoroutine(a);
                flag = true;
                gameObject.transform.rotation = defaultPosition;
                gameObject.transform.Rotate(new Vector3(0.0001f, 0, 0));
                isCoroutine = false;
                break;
            }




            if (flag)
            {
                if (gameObject.transform.localEulerAngles.x >= 0.95f * lowLimit && gameObject.transform.localEulerAngles.x <= lowLimit)
                {
                    newSpeed = 0.1f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.9f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.95f * lowLimit)
                {
                    newSpeed = 0.25f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.8f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.9f * lowLimit)
                {
                    newSpeed = 0.45f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.6f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.8f * lowLimit)
                {
                    newSpeed = 0.7f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.35f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.6f * lowLimit)
                {
                    newSpeed = 0.9f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0 && gameObject.transform.localEulerAngles.x <= 0.35f * lowLimit)
                {
                    newSpeed = speed;
                }



                else if (gameObject.transform.localEulerAngles.x <= 360 && gameObject.transform.localEulerAngles.x >= 360 - (0.35f * lowLimitt))
                {
                    newSpeed = speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.35f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.6f * lowLimitt))
                {
                    newSpeed = 0.9f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.6f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.8f * lowLimitt))
                {
                    newSpeed = 0.7f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.8f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.9f * lowLimitt))
                {
                    newSpeed = 0.45f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.9f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.95f * lowLimitt))
                {
                    newSpeed = 0.25f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.95f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - lowLimitt)
                {
                    newSpeed = 0.1f * speed;
                }

                gameObject.transform.Rotate(-Mathf.Cos(Mathf.Asin(0.01f * lowLimit)) * newSpeed, 0, 0);


                if (gameObject.transform.localEulerAngles.x >= 360 - lowLimitt - 0.1f && gameObject.transform.localEulerAngles.x <= 360 - lowLimitt + 0.1f)
                {
                    maxDeflectionAngle.text = (360 - gameObject.transform.localEulerAngles.x).ToString();
                    flag = false;
                    lowLimit -= difference;
                }
            }


            else
            {
                if (gameObject.transform.localEulerAngles.x <= 360 - (0.95f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - lowLimitt)
                {
                    newSpeed = 0.1f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.9f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.95f * lowLimitt))
                {
                    newSpeed = 0.25f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.8f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.9f * lowLimitt))
                {
                    newSpeed = 0.45f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.6f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.8f * lowLimitt))
                {
                    newSpeed = 0.7f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 - (0.35f * lowLimitt) && gameObject.transform.localEulerAngles.x >= 360 - (0.6f * lowLimitt))
                {
                    newSpeed = 0.9f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x <= 360 && gameObject.transform.localEulerAngles.x >= 360 - (0.35f * lowLimitt))
                {
                    newSpeed = speed;
                }





                else if (gameObject.transform.localEulerAngles.x >= 0 && gameObject.transform.localEulerAngles.x <= 0.35f * lowLimit)
                {
                    newSpeed = speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.35f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.6f * lowLimit)
                {
                    newSpeed = 0.9f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.6f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.8f * lowLimit)
                {
                    newSpeed = 0.7f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.8f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.9f * lowLimit)
                {
                    newSpeed = 0.45f * speed;
                }
                else if (gameObject.transform.localEulerAngles.x >= 0.9f * lowLimit && gameObject.transform.localEulerAngles.x <= 0.95f * lowLimit)
                {
                    newSpeed = 0.25f * speed;
                }
                if (gameObject.transform.localEulerAngles.x >= 0.95f * lowLimit && gameObject.transform.localEulerAngles.x <= lowLimit)
                {
                    newSpeed = 0.1f * speed;
                }



                gameObject.transform.Rotate(Mathf.Cos(Mathf.Asin(0.01f * lowLimitt)) * newSpeed, 0, 0);



                if (gameObject.transform.localEulerAngles.x >= lowLimit - 0.1f && gameObject.transform.localEulerAngles.x <= lowLimit + 0.1f)
                {
                    maxDeflectionAngle.text = gameObject.transform.localEulerAngles.x.ToString();
                    if (!text.text.Equals("") && script.counterIsStopped == false)
                    {
                        count++;
                        text.text = count.ToString();
                    }
                    lowLimitt -= difference;
                    flag = true;
                }
            }


            yield return null;

            break;
        }
        
    }


    
}
