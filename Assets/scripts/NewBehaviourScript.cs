using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
	public Image img1;
	public Image img2;
	public Image img3;
	public Image img4;
	public Image img5;
	public Image img6;
	public Image img7;
	public Image img8;
	public Image img9;
	public Image img10;

	// Use this for initialization
	void Start () {
		img1.gameObject.SetActive (true);
		img2.gameObject.SetActive (true);
		img3.gameObject.SetActive (true);
		img4.gameObject.SetActive (true);
		img5.gameObject.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		if (controler.health == 90) {
			img1.gameObject.SetActive (false);
		} else if (controler.health == 80) {
			img2.gameObject.SetActive (false);
		} else if (controler.health == 70) {
			img3.gameObject.SetActive (false);
		} else if (controler.health == 60) {
			img4.gameObject.SetActive (false);
		} else if (controler.health == 50) {
			img5.gameObject.SetActive (false);
		}
		else if (controler.health == 40) {
			img6.gameObject.SetActive (false);
		}
		else if (controler.health == 30) {
			img7.gameObject.SetActive (false);
		}
		else if (controler.health == 20) {
			img8.gameObject.SetActive (false);
		}
		else if (controler.health == 10) {
			img9.gameObject.SetActive (false);
		}
	

}
}