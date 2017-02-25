using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Paddle : MonoBehaviour
{





	[SerializeField]
	private BoxCollider2D collide;

	[SerializeField]
	private float speed;
	
	//private float RandomX = Random.Range (-2.3f,2.3f);


	private Vector3 pos1;
	//= new Vector3(-2.72f,4.87f,0);//left



	private Vector3 pos2;
	//= new Vector3(2.72f,4.87f,0);//right


	[SerializeField]
	private GameObject smoke;




	[SerializeField]
	private AudioSource source;


	[SerializeField]
	private AudioClip hit;
	
	public static int Score;

	public static string comment;

	
	[SerializeField]
	private GameObject BallClone;





	Color[] colors = {
		
		new Color (105f / 255, 3f / 255, 171f / 255),
		new Color (255f / 255, 0f / 255, 174f / 255),
		new Color (255f / 255, 185f / 255, 0f / 255),
		new Color (255f / 255, 0f / 255, 0f / 255),
		new Color (255f / 255, 255f / 255, 255f / 255),
		new Color (0f / 255, 0f / 255, 0f / 255)



	};

	

	void Awake ()
	{


		pos1 = new Vector3 (-2.72f, 4.87f, 0f);

		pos2 = new Vector3 (2.72f, 4.87f, 0f);

		collide.isTrigger = true;

		speed = 1.4f;

	
	
	
	}

	void Update ()
	{
		


		transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong (Time.time * speed, 1.0f));
			



		//transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);




	}


	void OnTriggerEnter2D (Collider2D target)
	{
		GameObject smokePuff = Instantiate (smoke, transform.position, Quaternion.identity) as GameObject;
		smokePuff.GetComponent<ParticleSystem> ().startColor = colors [Random.Range (0, colors.Length)];
		Destroy (target.gameObject);
		source.PlayOneShot (hit);
		Score++;
		BeatScoreLogic ();
		LogicComment ();
		GameplayController.variable.SetScore (Score);
			
			

		Instantiate (BallClone, new Vector3 (0f, -5.43f, 0f), Quaternion.identity);
		GameObject.FindGameObjectWithTag ("Player").GetComponent<BallScript> ().controlWhooSound = false;

	}

	

 
	void LogicComment ()
	{

		if (Score > 0 && Score < 6) {

			comment = "Douche Bag";


		} else if (Score > 5 && Score < 11) {

			comment = "Keep it up!";

		} else if (Score > 10 && Score < 16) {

			comment = "Creative Artist";

		} else if (Score > 15 && Score < 21) {

			comment = "Inspire People";

		} else if (Score > 20 && Score < 26) {

			comment = "Batman";

		} else if (Score > 25 && Score < 31) {

			comment = "Suprman";

		} else if (Score > 30) {

			comment = "Legend";

		}
      


	}

	void BeatScoreLogic ()
	{
		if (Score >= GamePrefrences.GetHighScore ()) {

		}
		


		



	}


}
	


