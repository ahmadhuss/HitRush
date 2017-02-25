using UnityEngine;
using System.Collections;

public class BackgroundLoop : MonoBehaviour {

	public Vector2 speed =Vector2.zero;
	private Vector2 offset = Vector2.zero;
	private Material material;

	public bool bgstart;


	void Start () {
		bgstart = true;
		material = GetComponent<Renderer> ().material;
		offset = material.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		if (bgstart) {
			offset += speed * Time.deltaTime;
			material.SetTextureOffset ("_MainTex", offset);
	
		}
		
		}
}