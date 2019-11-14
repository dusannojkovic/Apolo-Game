using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMove : MonoBehaviour {

public GameObject cube;
Renderer rend;
	void OnTriggerEnter(Collider collider)
	{
			if(collider.gameObject.tag == "Friendly"){

				cube.transform.position = new Vector3(0,25,0);

			}
	}
}
