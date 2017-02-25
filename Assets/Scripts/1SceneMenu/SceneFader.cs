using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour {

	public static SceneFader instance;

	[SerializeField]
	private GameObject canvas;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private bool fading = false;

	void Awake(){

		makeSingleton ();
	}


	public void FadeIn(string levelname)
	{
		StartCoroutine(FadeInAnimation(levelname));
		
		
	}
	
	void makeSingleton(){
        
                if (instance != null) {

                    Destroy (gameObject);
                } else {
                    instance = this;
                    DontDestroyOnLoad(gameObject);

                }
    }

  
	IEnumerator FadeInAnimation(string levelname)
    {
		if (fading) yield break;
		fading = true;
        canvas.SetActive(true);
        anim.Play("FadeIn");
        yield return StartCoroutine(MyCoroutine.WaitReal(.7f));
		SceneManager.LoadScene (levelname);
        anim.Play("FadeOut");
        yield return StartCoroutine(MyCoroutine.WaitReal(.5f));
        canvas.SetActive(false);
		fading = false;
    }

}