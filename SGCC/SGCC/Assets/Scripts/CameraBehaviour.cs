using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	[Header("Object Reference")]
	public Transform target;

	[Header("Camera Properties")]
	[Range(0.5f, 10f)]
	public float speed = 1.5f;

	public float distanceFromCam = 2.0f;

	private Camera cam;

	// Use this for initialization
	void Start () 
	{
		cam = GetComponent<Camera> ();

		if(target)
			transform.position = target.position + new Vector3(0, 0, -10);
	}

	// Update is called once per frame
	void Update () 
	{
		cam.orthographicSize = (Screen.height / 100f);



		if (target) {
			if (Vector3.Distance (transform.position, target.position)
				> distanceFromCam) {	
				Vector3 cameraPosition = Vector3.Lerp (transform.position,
					target.position,
					Time.deltaTime * speed);

				cameraPosition.z = -10;

				transform.position = cameraPosition;
			}
		}


	}
}
