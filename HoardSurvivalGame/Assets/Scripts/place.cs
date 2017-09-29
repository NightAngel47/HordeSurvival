using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class place : MonoBehaviour {

	public GameObject wall;
	public Text wallsRemaining;

	private int wallsPlaced;

	void Update() {

		wallsPlaced = GameObject.FindGameObjectsWithTag ("placeableWall").Length;
		wallsRemaining.text = (2 - wallsPlaced).ToString ();


		if (Input.GetMouseButtonDown(1)) {
			RaycastHit hit;
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)); //Establishes raycast
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.gameObject.tag == "ground" && wallsPlaced <= 1) {

					Instantiate (wall, hit.point, Quaternion.identity); //Instantiates walls
				
				} else if (hit.collider.gameObject.tag == "placeableWall") {
					Destroy(hit.collider.gameObject); //destroys walls
				}
			}
				
		}
	}

}
