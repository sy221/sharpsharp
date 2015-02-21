using UnityEngine;
using System.Collections;

public class f01_spawner : MonoBehaviour {
	public GameObject block;

	private int level = 1;
	private float timer = 0;
	private float levelupTimer = 0;
	private float spawnTime = 0;

	private int direction = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Random.Range(-5f, 5f),transform.position.y, transform.position.z);
		timer += Time.deltaTime;
		levelupTimer += Time.deltaTime;
		spawnTime += Time.deltaTime;
		if(spawnTime > 2f / (level+0.1f)){
			spawn();
		}

		if(levelupTimer > 5f){
			LevelUp();
		}

		if(timer > 30f){
			NextGame();
		}
	}

	void LevelUp(){
		level += 1;
		levelupTimer = 0;

	}

	void NextGame(){

	}

	void spawn(){
		GameObject bl = (GameObject)Instantiate (block, transform.position, transform.rotation);
		bl.name = "Cube";
		spawnTime = 0;

	}
}
