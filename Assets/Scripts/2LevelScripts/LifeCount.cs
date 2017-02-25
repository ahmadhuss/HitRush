using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeCount : MonoBehaviour {





	public static int LifeM=1;









	void OnTriggerEnter2D(Collider2D target) {

		if(target.tag=="Player"){
			LifeM--;
			RedFade.instance.Aware();
			GameplayController.variable.SetLifeScore (LifeM);


		if(LifeM<0){
			GameObject.FindGameObjectWithTag("CloudRespawner").GetComponent<CloudRespawn>().enabled = false;
			GameObject.FindGameObjectWithTag("TouchButton").GetComponent<Button>().interactable = false;
			GameObject.FindGameObjectWithTag("LifeText").GetComponent<Text>().enabled = false;
			GameObject.FindGameObjectWithTag("Background").GetComponent<BackgroundLoop>().bgstart = false;
			GameObject.FindGameObjectWithTag("Paddle").GetComponent<Paddle>().enabled = false;
			GameObject.FindGameObjectWithTag("Pause").GetComponent<Button>().enabled = false;
                if (GameManager.instance != null) {
                    GameManager.instance.checkGameStatus(Paddle.Score, LifeM, Paddle.comment);
                }


            }

	
	
	
	}


	}


}