using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class StopButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;

    [SerializeField]
    private Text text;

    Vector3 defaultPosition;

    public bool counterIsStopped = false;

    private void Start()
    {
        defaultPosition = obj.transform.position;
    }

    private void Update()
    {

    }

    public void OnMouseDown()
    {
        if (text.text != "")
        {
            counterIsStopped = !counterIsStopped;
        }
        Move();
    }

    public async Task Move()
    {

        obj.transform.position = new Vector3(-0.5f, obj.transform.position.y, obj.transform.position.z);
        await Task.Delay(100);
        obj.transform.position = defaultPosition;

    }
}
