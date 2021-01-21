using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalipersScript : MonoBehaviour
{
    public bool IsCoroutine = false;
    public bool flag = false;
    public int position = 1;

    [SerializeField]
    private GameObject obj;

    [SerializeField]
    private GameObject PracticeButton;

    [SerializeField]
    private GameObject MainCamera;

    [SerializeField]
    private Transform Position;

    [SerializeField]
    private Transform DefaultPosotionOfCamera;

    [SerializeField]
    private GameObject PracticeInfo;

    Replacer replacer;
    CameraScript cameraScript;

    PracticeButtonScript script;

    Coroutine a;

    int count;

    public Vector3 defaultPosition;


    private void Start()
    {
        count = 0;
        defaultPosition = obj.transform.position;
        script = PracticeButton.GetComponent<PracticeButtonScript>();
        replacer = MainCamera.GetComponent<Replacer>();
        cameraScript = MainCamera.GetComponent<CameraScript>();
    }




    private void Update()
    {

        if (IsCoroutine)
        {
            if (flag)
            {
                position = 2;
                obj.transform.position = Vector3.Lerp(obj.transform.position, new Vector3(0.213f, 0.815f, -0.028f), Time.deltaTime * 1.5f);
                a = StartCoroutine("Rotation");
            }
            else
            {
                position = 1;
                obj.transform.position = Vector3.Lerp(obj.transform.position, defaultPosition, Time.deltaTime * 1.5f);
                a = StartCoroutine("Rotation");
            }
        }

        if(script.step == 3)
        {
            IsCoroutine = true;
            count = 0;
            flag = false;
            replacer.MoveTo(DefaultPosotionOfCamera);
        }
    }


    public void OnMouseDown()
    {
        if(script.step == 1)
        {
            count++;
            if (count == 1)
            {
                flag = true;
                IsCoroutine = true;
                replacer.MoveTo(Position);
            }
        }
        
    }


    public void Rotate()
    {
        count++;
        if (count == 1)
        {
            flag = true;
            IsCoroutine = true;
        }
        else if(count==2)
        {
            flag = false;
            IsCoroutine = true;
            count = 0;
        }
    }
    public IEnumerator Rotation()
    {
        if (flag)
        {
            if ((int)obj.transform.localEulerAngles.x != 0)
            {
                if ((int)obj.transform.localEulerAngles.x < 359)
                {
                    obj.transform.Rotate(new Vector3(0.5f, 0.0f, 0.0f));
                }
                else if ((int)obj.transform.localEulerAngles.x == 359)
                {
                    StopCoroutine(a);
                    
                }
            }
        }
        yield return null;


        if (!flag)
        {
            if ((int)obj.transform.localEulerAngles.x != 270)
            {
                if ((int)obj.transform.localEulerAngles.x > 271)
                {
                    obj.transform.Rotate(new Vector3(-0.5f, 0.0f, 0.0f));
                }
                else if ((int)obj.transform.localEulerAngles.x == 271)
                {
                    position--;
                    StopCoroutine(a);
                    
                }
            }
        }
        yield return null;
    }

}
