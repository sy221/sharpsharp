using UnityEngine;
using System.Collections;

public class f01_block : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collider other){
		if(other.gameObject.name == "DefaultAvatar"){

		}else if(other.gameObject.name == "floor"){

		}
		Destroy (this);
	}
}