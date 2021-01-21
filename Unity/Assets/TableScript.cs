using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TableScript : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private GameObject Table;

    [SerializeField]
    private GameObject PracticeButton;

    PracticeButtonScript script;

    bool isActive = false;

    void Start()
    {
        Table.SetActive(false);
        script = PracticeButton.GetComponent<PracticeButtonScript>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isActive = !isActive;
        Table.SetActive(isActive);
    }
}
