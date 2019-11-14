using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// if (Input.GetKey(KeyCode.K))
		// {
			Fire();
				//  Fire();
		// }
	}
	void Fire()
	{
		GameObject bullet = (GameObject)Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
		// Debug.Log(bullet.transform.forward);
		Destroy(bullet,5);
	}
}
