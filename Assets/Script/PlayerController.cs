using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	// Update is called before anything renders in the frame. This is where bulk of code will go 
//	void Update() {
//	
//	}
//

	private Rigidbody rb;
	public float speed;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// called before any physics calculations occur
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other)
	{
		//Destroy (other.gameObject);
		if(other.gameObject.CompareTag("Pick Up")){
				other.gameObject.SetActive(false);
		}
	}
	
}