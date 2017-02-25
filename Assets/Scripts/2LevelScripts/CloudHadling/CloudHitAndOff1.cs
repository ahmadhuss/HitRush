using UnityEngine;
using System.Collections;

public class CloudHitAndOff1 : MonoBehaviour {
	[SerializeField]
	private AudioSource source;
	
	[SerializeField]
	private AudioClip cloudTouch;
	

	[SerializeField]
	private GameObject BallClone;


	void OnTriggerEnter2D(Collider2D target){

		if(target.tag=="Player"){
			source.PlayOneShot(cloudTouch);
			Destroy(target.gameObject);
			Instantiate (BallClone, new Vector3 (0f, -5.43f, 0f), Quaternion.identity);

		}

		else if(target.tag=="coil2"){
		gameObject.SetActive(false);
	
	}


}

}