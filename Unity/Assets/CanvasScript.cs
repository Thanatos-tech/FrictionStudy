using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    [SerializeField]
    private InfoScript Info;
	[SerializeField]
	private GameObject PracticeInfo;
	[SerializeField]
	private GameObject Table;


	[SerializeField]
	private BallButtonScript Button1;
	[SerializeField]
	private ThreadButtonScript Button2;
	[SerializeField]
	private ColumnButtonScript Button3;
	[SerializeField]
	private ScaleButtonScript Button4;
	[SerializeField]
	private PlastineButtonScript Button5;
	[SerializeField]
	private CounterButtonScript Button6;

	void Start()
    {
        Info.Close();
		PracticeInfo.SetActive(false);
		Table.SetActive(false);

		Button1.Close();
		Button2.Close();
		Button3.Close();
		Button4.Close();
		Button5.Close();
		Button6.Close();
	}
}
