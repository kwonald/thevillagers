using UnityEngine;
using System.Collections;

public class CameraRotatorviaAnchor : MonoBehaviour {



	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0.0f, 5, 0.0f)*Time.deltaTime);
	}
}
