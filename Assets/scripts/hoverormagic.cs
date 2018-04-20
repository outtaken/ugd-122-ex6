using UnityEngine;
using System.Collections;

public class hoverormagic : MonoBehaviour {

	public float hovermagic = 10f;
	void OnTriggerStay (Collider other){
		other.rigidbody.AddForce(Vector3.up*hovermagic,ForceMode.Acceleration);
	}
}
