using UnityEngine;
using System.Collections;

public class BGScalerQuadtoCamera : MonoBehaviour {
	//yani k quad background k size k mutabik ho jaye ga
	/* Scale our background to fill the whole screen that the way we can support multiple screen resolution
	 * using our quads
	 * Take the scalw of our quad or us ko resize karna hai camera k orthographic size k jo default 5 hai
	 * 
	 * 
	 */ 

	//yeh script hai Quad ko Camera k mutabik karney k liye for example

	void Start () {
	


		//Calculate the  height(height of our quad which is y scale=1 default)
		var height = Camera.main.orthographicSize * 2f;//this is y scale of our quad
		//now calculate width
		var width = height * Screen.width / Screen.height;//this is x scale of our quad

		if (gameObject.name == "Quad") {

			transform.localScale = new Vector3(width,height,0);
		}

	}
	

}