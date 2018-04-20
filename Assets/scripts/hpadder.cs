using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpadder : MonoBehaviour {
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
		img10.gameObject.SetActive (false);
		img9.gameObject.SetActive (false);
		img8.gameObject.SetActive (false);
		img7.gameObject.SetActive (false);
		img6.gameObject.SetActive (false);
		img5.gameObject.SetActive (false);
		img4.gameObject.SetActive (false);
		img3.gameObject.SetActive (false);
		img2.gameObject.SetActive (false);
		img1.gameObject.SetActive (false);

	}

	

	// Update is called once per frame
	void Update ()
	{
		if (controler.health == 90) {
			img10.gameObject.SetActive (true);
		} else if (controler.health == 80) {
			img9.gameObject.SetActive (true);
		} else if (controler.health == 70) {
			img8.gameObject.SetActive (true);
		} else if (controler.health == 60) {
			img7.gameObject.SetActive (true);
		} else if (controler.health == 50) {
			img6.gameObject.SetActive (true);
		} else if (controler.health == 40) {
			img5.gameObject.SetActive (true);
		} else if (controler.health == 30) {
			img4.gameObject.SetActive (true);
		} else if (controler.health == 20) {
			img3.gameObject.SetActive (true);
		} else if (controler.health == 10) {
			img2.gameObject.SetActive (true);
		}

	}

	void OnTriggerEnter (Collider other)
	{
		
		if (controler.health < 100) {
			controler.health += 10;
			print ("hp resumed");
		} else {
			print ("hp is full");
		}
		if (controler.health == 90) {
			img10.gameObject.SetActive (true);
		} else if (controler.health == 80) {
			img9.gameObject.SetActive (true);
		} else if (controler.health == 70) {
			img8.gameObject.SetActive (true);
		} else if (controler.health == 60) {
			img7.gameObject.SetActive (true);
		} else if (controler.health == 50) {
			img6.gameObject.SetActive (true);
		} else if (controler.health == 40) {
			img5.gameObject.SetActive (true);
		} else if (controler.health == 30) {
			img4.gameObject.SetActive (true);
		} else if (controler.health == 20) {
			img3.gameObject.SetActive (true);
		} else if (controler.health == 10) {
			img2.gameObject.SetActive (true);
		}
	}
}
