using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;
	//private PrikBlokScript prik;
	GameObject prik;
	Vector3 prikPos;
	Vector3 rotationAngle;
	bool rotateLeft;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
		prik = transform.FindChild ("PrikBlok").gameObject;
		prik.SetActive(false);
		prikPos = Vector3.zero;
		prikPos = transform.TransformPoint (prikPos);
		bool rotateLeft = false;
	}

	void FixedUpdate () 
	{

		Vector3 position = rb.position;

		if (Input.GetKey(KeyCode.A)) {
			position.x -= speed;
		}
		if (Input.GetKey (KeyCode.D)) {
			position.x += speed;
		}
		if (Input.GetKey (KeyCode.W)) {
			position.z += speed;
		}
		if (Input.GetKey (KeyCode.S)) {
			position.z -= speed;
		}

//		if (Input.GetKey (KeyCode.UpArrow)) {
//			prik.SetActive (true);
//		} else {
//			prik.SetActive (false);
//		}
		position.y = 0.5f;
		rb.position = position;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			prik.SetActive (true);

			if(!rotateLeft){
			rotateLeft = true;
			prik.transform.RotateAround(rb.position, Vector3.up, 90);
			}

		} 
		else {
			prik.SetActive(false);
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			prik.transform.RotateAround(rb.position, Vector3.up, -90);
			rotateLeft = false;
		}


	}




}