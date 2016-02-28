using UnityEngine;
using System.Collections;

public class Spectrum : MonoBehaviour {

	// C#
	// Instantiates a prefab in a circle

	public GameObject prefab;
	public int numberOfObjects = 20;
	public float radius = 5f;
	public GameObject[] cubes;
	public int scaleFactor;
	void Start() {
//		var center = transform.position;
//		Vector3 pos; 
		for (int i = 0; i < numberOfObjects; i++) {
			float angle = i * Mathf.PI * 2 / numberOfObjects;
			Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
//			pos.x = center.x + radius *Mathf.Sin(angle);
//			pos.z = center.z + radius * Mathf.Cos (angle);
//			pos.y = center.z;
//			var rot = Quaternion.FromToRotation (Vector3.forward, center - pos);
			Instantiate(prefab, pos, Quaternion.identity);
//			Instantiate(prefab, pos, rot);
		}
		cubes = GameObject.FindGameObjectsWithTag ("cubes");
	}
	
	// Update is called once per frame
	void Update () {
		float[] spectrum = AudioListener.GetSpectrumData (1024, 0, FFTWindow.Hamming);
		for (int i = 0; i < numberOfObjects; i++) {
			Vector3 previousScale = cubes [i].transform.localScale;
			previousScale.y = Mathf.Lerp (previousScale.y, spectrum [i] * scaleFactor, Time.deltaTime * 30);
			cubes [i].transform.localScale = previousScale;

		}

	}
}
