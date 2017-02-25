using UnityEngine;
using System.Collections;
//bhai hum List use karney lagey hai iss liye System collection Generic
using System.Collections.Generic;

public class CloudRespawn : MonoBehaviour {

	
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
			//ab create karna hai tu  TYPE CAST ker diya as GameObject
			GameObject obj  = Instantiate(clouds[index],new Vector3(transform.position.x,transform.position.y,-2f),Quaternion.identity) as GameObject;
			//ab humey in clouds ko list mein add karna hai
			listname.Add(obj);

			//humey abi ussey active nahi karna scene mein
			listname[i].SetActive(false);
			//increment index
			index++;

			//agar index clouds ki length ke braber ho jaye
			if(index==clouds.Length){
				//cloud 2 hai array mein lekin length 3 iss liye reset index
				//reset index
				index =0;

			}


		}

	}







	void shuffle(){
		//shuffle our list length
		for (int i=0; i<listname.Count; i++) {
			//Temporary GameObject
			GameObject temp = listname [i];
			//random
			int random = Random.Range (i, listname.Count);
			//rearrange our GameObject
			listname [i] = listname [random];

			//jo random index mein element hai wo equal ho jaye temporary element key
			listname [random] = temp;

			/*
			 * For Example
			 * list 0 index mein Value 3
			 * List [0] = 3;
			 * aur random mein 
			 * List[random] = 5;
			 */ 

		}//loop END
	}

		IEnumerator RandomCloudSpawn(){

			yield return new WaitForSeconds(Random.Range(0f,1.5f));
			


		int index = Random.Range (0, listname.Count);


			//search for a gameobject that is not ACTIVE
			//Explanation mark mean if the element is not active
			if(!listname[index].activeInHierarchy){
				//tab hum same element le gey aur kahey gey yeh true hu jaye
				listname[index].SetActive(true);

				//Position humarey cloud ki
				listname[index].transform.position = new Vector3(transform.position.x,transform.position.y,-2f);


				//break loop because we found GameObject jo active nahi hai wo set ho jaye active
				//then break

			}

		else{

				//search another gameobject thats not active kyon k jo active hai hum ussey dobara
				//nahi karna chahtey
				index = Random.Range(0,listname.Count);
			}
		}

	public void SpawnIt(){
		
		StartCoroutine (RandomCloudSpawn());
		
	}


}