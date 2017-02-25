using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloudRespawn1 : MonoBehaviour {

	[SerializeField]
	private GameObject[] clouds;
	private List<GameObject> listname = new List<GameObject>();


	void Awake(){

		InitilizeCloud ();
	}

	void Start () {
		StartCoroutine(RandomCloudSpawn());

	}
	
	
	void InitilizeCloud(){

		int index = 0;
		for (int i=0; i<clouds.Length; i++) {
			GameObject obj  = Instantiate(clouds[index],new Vector3(transform.position.x,transform.position.y,-2f),Quaternion.identity) as GameObject;
			listname.Add(obj);
			listname[i].SetActive(false);
			index++;
			if(index==clouds.Length){
				index =0;

			}


		}

	}







	void shuffle(){

		for (int i=0; i<listname.Count; i++) {

			GameObject temp = listname [i];

			int random = Random.Range (i, listname.Count);

			listname [i] = listname [random];

			listname [random] = temp;

			

		}
	}

		IEnumerator RandomCloudSpawn(){

			yield return new WaitForSeconds(Random.Range(0f,1.5f));
			


		int index = Random.Range (0, listname.Count);


			
			if(!listname[index].activeInHierarchy){
				listname[index].SetActive(true);

				listname[index].transform.position = new Vector3(transform.position.x,transform.position.y,-2f);

			}

		else{

				index = Random.Range(0,listname.Count);
			}
		}
	

	public void Genrator(){
		
		StartCoroutine (RandomCloudSpawn());
		
	}

}