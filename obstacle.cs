using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour {

    public float speed = 1;	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += Vector3.down * speed * Time.deltaTime;
       
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("trigger2");
        if (gameObject.layer != 8)
            Debug.Log("trigger1");
        SceneManager.LoadScene("sceen2");

    }
}
