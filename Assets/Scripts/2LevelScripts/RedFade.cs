using UnityEngine;
using System.Collections;

public class RedFade : MonoBehaviour {

	public static RedFade instance;
	
	[SerializeField]
	private GameObject Redpanel;
	
	[SerializeField]
	private Animator anim;
	
	void Awake(){
		
		makeInstance ();
	}
	
	void makeInstance(){
		
		if (instance == null) {
			//this mean yeh jis gameobject per hai uss ka instance ban jaye
			instance = this;
		
		}
	}

	
	
	public void Aware(){
		StartCoroutine (PerformFader());

	}

	IEnumerator PerformFader(){

		Redpanel.SetActive (true);

		anim.Play ("FadeIn");

		yield return new WaitForSeconds (0.1f);//tab tak animation complete huvi

		anim.Play ("FadeOut");
		
		yield return new WaitForSeconds (0.1f);
		
		Redpanel.SetActive (false);



	}
	
	
}