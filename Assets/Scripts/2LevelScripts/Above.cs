using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Above : MonoBehaviour {

    
	[SerializeField]
	private AudioSource source;

	[SerializeField]
	private AudioClip ExitBorder;



	[SerializeField]
	private BoxCollider2D collide;




	[SerializeField]
	private GameObject BallClone;



		
		void Awake () {
			collide.isTrigger = true;

		}
		
		
		void OnTriggerEnter2D(Collider2D target) {
		source.PlayOneShot (ExitBorder);
		Destroy (target.gameObject);
		Instantiate (BallClone, new Vector3 (0f, -5.43f, 0f), Quaternion.identity);

		GameObject.FindGameObjectWithTag ("Player").GetComponent<BallScript> ().controlWhooSound = false;



		
	}	
	

}