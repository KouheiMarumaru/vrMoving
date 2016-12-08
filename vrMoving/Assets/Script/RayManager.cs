using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayManager : MonoBehaviour {

	public GameObject dive_Camera;
	public Image reticle;
	public int f;
//	RaycastHit hit;

	public GameObject player;

	//rayで示した地点
	Vector3 newPlayerPosition;

	//オブジェクトが到達するまでの時間
	float time = 0;



	//	public GameObject alignment;

//	void Start () {
//		StartCoroutine("MoveSphere");
//	}

	void Update () {
//		time = 0;
		//ある起点から、特定の方向に向けて出す光線を生成
		//起点がdive_Cameraの位置、方向がdive_Cameraから見て前方向に向けて光線
		Ray ray = new Ray (dive_Camera.transform.position, dive_Camera.transform.forward);

		RaycastHit hit = new RaycastHit ();
//		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			//hitした場所にImageであるalignmentが表示される
//			reticle.rectTransform.position = hit.point;
//			alignment.transform.position = hit.point;
			newPlayerPosition = hit.point;
			Debug.DrawLine (dive_Camera.transform.position, newPlayerPosition, Color.black);
			print (newPlayerPosition);

//			StartCoroutine("MoveSphere");

			time = Time.deltaTime * 1f;
			player.transform.position = Vector3.Lerp (player.transform.position, newPlayerPosition, time);
		}
	}


//			IEnumerator MoveSphere(){
//
//		this.gameObject.transform.position = hit;
//
//		yield return new WaitForSeconds(0.01f);
//
//	}
}
