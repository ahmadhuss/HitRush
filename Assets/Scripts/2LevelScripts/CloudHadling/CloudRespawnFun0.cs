using UnityEngine;
using System.Collections;

public class CloudRespawnFun0 : MonoBehaviour {

	public CloudRespawn respawn;


	
	void OnTriggerEnter2D(Collider2D target){
		respawn.SpawnIt ();
		
	}



}