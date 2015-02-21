using UnityEngine;
using System.Collections;

public class f01_controller : MonoBehaviour {
	private float speed = 0.5f;
	private Animator anim;
	private bool direction;
	private float v;
	private bool keylock = false;
	private AnimatorStateInfo state;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		state = GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0);
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis("Horizontal")*speed;
		if(v > 0){
			transform.rotation = Quaternion.Euler(0,90f,0);
		}else if(v < 0){
			transform.rotation = Quaternion.Euler(0,-90f,0);
		}
		if(!keylock){
			idou ();
		}

	}



	void idou(){
		anim.SetFloat("speed", Mathf.Abs(v));
		Vector3 velocity = new Vector3 (v,0,0);
		transform.position += velocity * Time.deltaTime;
	}


	void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "Cube"){
			anim.SetBool("damage", true);
			keylock = true;
			StartCoroutine("wait", 1.5f);
		}

	}

	IEnumerator wait(float time){
		yield return new WaitForSeconds (time);
		if(state.nameHash != Animator.StringToHash("Base Layer.damage")){
			keylock = false;
			anim.SetBool("damage", false);
		}

	}
	
}
