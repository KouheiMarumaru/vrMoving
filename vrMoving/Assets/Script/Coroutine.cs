using UnityEngine;
using System.Collections;


public class Coroutine : MonoBehaviour {

	public int f;

	// Use this for initialization
	void Start () {
		StartCoroutine("MoveSphere");
	}


	// Update is called once per frame
	IEnumerator MoveSphere(){

			this.gameObject.transform.position = new Vector3(f*0.1f, 1, 1); 
			yield return new WaitForSeconds(0.01f);

	}
}