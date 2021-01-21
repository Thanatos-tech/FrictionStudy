using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacer : MonoBehaviour
{
    bool move = false;
    Vector3 startPosition;// = new Vector3(58.1f,17.1f,71.1f);
    Vector3 needPosition;
    float speed = 0.01f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

    }
    private void Move()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(5.45f, 8, -22.6f);
            needRotaton = new Quaternion(0.7f, 0, 0, 0.7f);
            //switching = true;
        }

    }
    public void MoveTo(Transform t)
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = t.transform.position;
        needRotaton = t.transform.rotation;
        offset = 0;
        move = true;
    }

    void FixedUpdate()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }

}
