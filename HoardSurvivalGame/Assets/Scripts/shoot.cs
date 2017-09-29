using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)); //Establishes raycast
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.gameObject.tag == "enemy") {
					Destroy(hit.collider.gameObject); //destroys enemy

				}
			}


		}
	}

}
