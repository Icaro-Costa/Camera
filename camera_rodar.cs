using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rodar : MonoBehaviour {

	public Transform cam, cam_y;
	public float distancia, Sensi_X, Sensi_Y, Angulo_Max, Angulo_Min;
	float mouse_x, mouse_y;

	void Start()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () {
		cam.transform.localPosition = new Vector3 (0,0,-distancia);
		mouse_x += Input.GetAxis ("Mouse X") * Sensi_X;
		mouse_y -= Input.GetAxis ("Mouse Y") * Sensi_Y;
		mouse_y = Mathf.Clamp (mouse_y, -Angulo_Min,Angulo_Max);
		transform.localEulerAngles = new Vector3 (0,mouse_x,0);
		cam_y.transform.localEulerAngles = new Vector3 (mouse_y,0,0);
	}
}
