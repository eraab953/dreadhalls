using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathFromHeight : MonoBehaviour {
	
	public int deathHeight = 0;
	private Rigidbody rb;
	public GameObject soundKill;


	

	
    // Start is called before the first frame update
    void Start()
    {
        	rb = GetComponent<Rigidbody>();
			soundKill = GameObject.FindWithTag("sounds");
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.y < 0) {
			Destroy(soundKill);
			LevelTrack.levelNumber = 0;
			SceneManager.LoadScene("GameOver");
			
		}
    }
}
