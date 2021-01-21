using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;

    [SerializeField]
    private Text text;

    [SerializeField]
    private GameObject thread;

    OscillationScript script;

    Vector3 defaultPosition;

    public bool isEnabled = false;

    private void Start()
    {
        defaultPosition = obj.transform.position;
        script = thread.GetComponent<OscillationScript>();
    }

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        isEnabled = !isEnabled;
        if (isEnabled)
        {
            text.text = "0";
            script.script.counterIsStopped = false;
        }
        else
        {
            text.text = "";
        }
        script.count = 0;
        Move();
    }

    public void ForClean()
    {
        isEnabled = !isEnabled;
        if (isEnabled)
        {
            text.text = "0";
            script.script.counterIsStopped = false;
        }
        else
        {
            text.text = "";
        }
        script.count = 0;
    }

    public async Task Move()
    {

        obj.transform.position = new Vector3(-0.5f, obj.transform.position.y, obj.transform.position.z);
        await Task.Delay(100);
        obj.transform.position = defaultPosition;

    }
}
