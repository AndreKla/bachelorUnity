using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	public Player player;

	void Awake() {

		DontDestroyOnLoad(this.gameObject);
	}
}
