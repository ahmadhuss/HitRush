using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallScript : MonoBehaviour
{

	private float PointerPos;


	[SerializeField]
	private AudioSource src;

	[SerializeField]
	private AudioClip ballwoh;


	private Button bt;

	public bool hasdropped;

	[SerializeField]
	private Rigidbody2D body;


	public bool controlWhooSound;

	void Awake ()
	{

		
		//take width of screen
		//	Vector3 gameScreen = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));

		//	BorderX = gameScreen.x - 0.3f; 

		bt = GameObject.FindGameObjectWithTag ("TouchButton").GetComponent<Button> ();
		bt.onClick.AddListener (BallShoot);

		body.isKinematic = true;

	}

	void Update ()
	{
		//It prevents the execution of all the code under it

		if (hasdropped) {
				
			return;  
		}

		//suck all postions temp variable vecor 3 we can manipulate axis
		Vector3 temp = transform.position;
				
		PointerPos = Camera.main.ScreenToWorldPoint (Input.mousePosition).x;
				
		//don't go outside
		temp.x = Mathf.Clamp (PointerPos, -2.704292f, 2.704292f);

		//and then reassign our position or back to current position
		body.position = temp;
	}

	public void BallShoot ()
	{
		//Pause se boolean true ho jaye ga default false pe work karta hai
		if (GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameplayController> ().pushButton == false) {
			GameObject.FindGameObjectWithTag ("Player").GetComponent<BallScript> ().hasdropped = true;
			GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D> ().isKinematic = false;
			    

			if (controlWhooSound == false) {
				src.PlayOneShot (ballwoh);
				controlWhooSound = true;
			}
		
		}

	}

	void OnDestroy ()
	{
		bt.onClick.RemoveListener (BallShoot);
	}

}