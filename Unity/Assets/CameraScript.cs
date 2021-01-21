using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int sensivity = 3;
    float maxdistance = 3.5f;
    float mindistance = 0.5f;
    [SerializeField]
    Transform targetPos;




    //  ФУНКЦИЯ ОГРАНИЧЕНИЯ ПРЕДЕЛОВ ДВИЖЕНИЯ КАМЕРЫ
    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance) return true;
        return false;
    }

    // ДВИЖЕНИЯ КАМЕРЫ
    void FixedUpdate()
    {
        // ДВИЖЕНИЕ В СТОРОНЫ КЛАВИШАМИ
        float x = Input.GetAxis("Horizontal"); // клавиши A, D
        float y = Input.GetAxis("Vertical"); // клавиши W, S
        if (x != 0 || y != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
        }

        // ПРИБЛИЖЕНИЕ И УДАЛЕНИЕ ПРОКРУТКОЙ КОЛЕСА МЫШИ
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            if (ControlDistance(Vector3.Distance(newpos, targetPos.position))) transform.position = newpos;
        }

        // ВРАЩЕНИЕ ВОКРУГ ЦЕНТРАЛЬНОЙ ТОЧКИ УСТАНОВКИ ЗАЖАТОЙ ПРАВОЙ КЛ. МЫШИ
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
            transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y") * sensivity);
        }
    }

}
