using UnityEngine;
using System.Collections;

public class TESTTRANS : MonoBehaviour {
	bool jump = false;
	private Animator anim;	
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			jump = true;
		}

		GetComponent<Animator>().SetBool("SPACE",jump);
		AnimatorStateInfo state = GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0);
		if (state.nameHash == Animator.StringToHash("Base Layer.SPACE") ) {
			transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		} else {
			Debug.Log ("!");
			jump = false;
			transform.localScale = new Vector3(1f,1f,1f);
		}



		
	}
}