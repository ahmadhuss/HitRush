using UnityEngine;
using System.Collections;

public class CloudRespawnFunction : MonoBehaviour {

	public CloudRespawn1 respawn;


	
	void OnTriggerEnter2D(Collider2D target){
		respawn.Genrator ();
		
	}



}