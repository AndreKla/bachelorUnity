using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public GameObject player;

	// Camera move rect!
	private float bottomLeftBorder, topLeftBorder, topRightBorder, bottomRightBorder;
	private float cameraPositionX, cameraPositionY;

	// Zoom variables
	public float min = 15f;
	public float max = 90f;
	public float sensitivity = 10f;

	// Pan Variables
	private float rightEdge,topEdge,leftEdge,bottomEdge;

	//Drag Variables
	private Vector3 dragStart;
	private bool cameraDragging = true;
	
	void Start(){
		
		topEdge = 100; leftEdge = 100;
		rightEdge = Camera.main.pixelWidth - 100;
		bottomEdge = Camera.main.pixelHeight - 100;
		
	}

	void Update()
	{
		cameraPositionX = this.gameObject.transform.position.x;
		cameraPositionY = this.gameObject.transform.position.y;

		if (cameraPositionX >= 15 && cameraPositionX <= 30 && cameraPositionY <= 20 && cameraPositionY >= 14.5f) {


						//zoom in and out
						float fov = Camera.main.fieldOfView;
						fov += Input.GetAxis ("Mouse ScrollWheel") * sensitivity;
						fov = Mathf.Clamp (fov, min, max);
						Camera.main.fieldOfView = fov;
				
						/*move camera through side edges
						if(Input.mousePosition.y >= topEdge && Input.mousePosition.y <= bottomEdge){
							print ("bin im rect");
						}
						if (Input.mousePosition.x <= leftEdge) {
							iTween.MoveTo(this.gameObject,iTween.Hash ("x",this.gameObject.transform.position.x - 1f,"time",1.5f,"easyType","linear"));
						}
						
						if(Input.mousePosition.x >= rightEdge){
							iTween.MoveTo(this.gameObject,iTween.Hash ("x",this.gameObject.transform.position.x + 1f,"time",1.5f,"easyType","linear" ));

						}*/
				
						//drag camera
						Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			
						float left = Screen.width * 0.2f;
						float right = Screen.width - (Screen.width * 0.2f);
			
						cameraDragging = true;

						if (cameraDragging) {
				
								if (Input.GetMouseButtonDown (0)) {
										dragStart = Input.mousePosition;
										return;
								}
				
								if (!Input.GetMouseButton (0))
										return;
				
								Vector3 pos = Camera.main.ScreenToViewportPoint (Input.mousePosition - dragStart);
								Vector3 move = new Vector3 (-pos.x * Time.deltaTime * 5f, -pos.y * Time.deltaTime * 5f, 0);

								transform.Translate (move, Space.World);
					
						}

		
		
		} 
		else {

			if(cameraPositionX <= 15f){
				this.gameObject.transform.position = new Vector3 (15f, this.transform.position.y, this.transform.position.z);
			}
			if(cameraPositionX >= 30f){
				this.gameObject.transform.position = new Vector3 (30f, this.transform.position.y, this.transform.position.z);
			}
			if(cameraPositionY <= 14.5f){
				this.gameObject.transform.position = new Vector3 (this.transform.position.x,14.5f, this.transform.position.z);
			}
			if(cameraPositionY >= 20f){
				this.gameObject.transform.position = new Vector3 (this.transform.position.x, 20f, this.transform.position.z);
			}
		}
	
	}

}
