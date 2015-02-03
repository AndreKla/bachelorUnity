using UnityEngine;
using System.Collections;

public class Animatorio : MonoBehaviour {
	
	private bool clicked = false;
	private Vector3 destination;
	private float speed = 50.0f;
	private float pPositionY;
	public Animator animator;

	private Vector3 target;
	
	void Start(){

		pPositionY = gameObject.transform.position.y;
		animator.GetComponent<Animator> ();

	}
	

	void Update () {
		
		if(Input.GetMouseButtonUp(0))
		{
			RaycastHit hit;
	
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray,out hit))
			{
				clicked = true;
				destination = hit.point;
				destination.y = pPositionY;
				print(destination.ToString ());
			}
			
		}

		if(clicked && !Mathf.Approximately(gameObject.transform.position.magnitude, destination.magnitude)){ 

			gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, destination, 1/(speed*(Vector3.Distance(gameObject.transform.position, destination))));
			gameObject.transform.LookAt(destination);
			animator.SetFloat ("walk", 0.2f);

		}

		else if(clicked && Mathf.Approximately(gameObject.transform.position.magnitude, destination.magnitude)) {
			clicked = false;
			animator.SetFloat ("walk",0.0f);
			print("I am here");
		}
		
	}
}
