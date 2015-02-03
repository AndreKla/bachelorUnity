using UnityEngine;
using System.Collections;

public class Graph : MonoBehaviour {

	public GameObject neuroticism;
	public GameObject extraversion;
	public GameObject openness;
	public GameObject agreeableness;
	public GameObject conciouseness;

	// Use this for initialization
	void Start () {

		TransformHeight (neuroticism, "neuroticism");
		TransformHeight (extraversion, "extraversion");
		TransformHeight (openness, "openness");
		TransformHeight (agreeableness, "agreeableness");
		TransformHeight (conciouseness, "conciouseness");	
	}
	
	public void TransformHeight(GameObject obj,string name){

		obj.transform.localScale = new Vector3 (obj.transform.localScale.x, obj.transform.localScale.y * PlayerPrefs.GetFloat (name) * 5f, obj.transform.localScale.z);
		obj.transform.position = new Vector3 (obj.transform.position.x, obj.transform.position.y + obj.renderer.bounds.size.y / 2f, obj.transform.position.z);
	
	}
}
