using UnityEngine;
using System.Collections;

	public class CloudsMove : MonoBehaviour {


		private float speed = -1.90f;
		
		void Update () {

		Vector3 pos = transform.position; 
		    
		pos.x += speed * Time.deltaTime;
			
		transform.position = pos;	
		

	
	}



}