using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnRotationScript : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;

    [SerializeField]
    private GameObject obj2;


    public int count;

    private void Start()
    {
        count = 0;
    }


    public void OnMouseDown()
    {
        count++;
        Rotation();
    }

    public void Rotation()
    {
        if (count == 1)
        {
            obj.transform.Rotate(new Vector3(-10.0f, 0.0f, 0.0f));
            obj2.transform.Rotate(new Vector3(0.0f, 0.0f, -10.0f));
        }
        else if (count == 2)
        {
            obj.transform.Rotate(new Vector3(-10.0f, 0.0f, 0.0f));
            obj2.transform.Rotate(new Vector3(0.0f, 0.0f, -10.0f));
        }
        else if (count == 3)
        {
            obj.transform.Rotate(new Vector3(-10.0f, 0.0f, 0.0f));
            obj2.transform.Rotate(new Vector3(0.0f, 0.0f, -10.0f));
        }
        else if (count == 4)
        {
            obj.transform.Rotate(new Vector3(-10.0f, 0.0f, 0.0f));
            obj2.transform.Rotate(new Vector3(0.0f, 0.0f, -10.0f));
        }
        else if (count == 5)
        {
            obj.transform.Rotate(new Vector3(40.0f, 0.0f, 0.0f));
            obj2.transform.Rotate(new Vector3(0.0f, 0.0f, 40.0f));
            count = 0;
        }

    }
}
