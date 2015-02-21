using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow) )
		{
			this.transform.position+= new Vector3 (0,0.3f,0);
				}

	}
}
