using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour {

	public ParticleSystem playParticle;
	private int brojac;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		for(int brojac = 0;brojac <= 100;brojac++)
		{
			if(brojac%2==0){
				playParticle.Emit(1);
			}
			else{
				playParticle.Stop();
			}
		}
		
	}
}
