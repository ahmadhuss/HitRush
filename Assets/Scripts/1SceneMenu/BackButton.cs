	using UnityEngine;
	using System.Collections;
	using UnityEngine.SceneManagement;

	public class BackButton : MonoBehaviour {


		public void GoBack(){
			GameManager.instance.gamestaretedFromMainMenu = false;
	        SceneFader.instance.FadeIn("MainMenu");
	    }
		public void GoRetry(){
			GameManager.instance.gamestaretedFromMainMenu = true;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		}



	}