using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public string logtext = "Hello world again";
    public float speed = 2;
    public float health = 100;
    // Use this for initialization
    void Start () {
        Debug.Log(logtext);
        Debug.Log("Hey world");
        Debug.Log("Ola world");
        Debug.Log("Sup world");
        Debug.Log("Konnichiwa world");
        
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Konnichiwa world");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        //Number beteen -1 and 1 based uponplayer presing left or right/a or d
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        Vector2 velocity = rigidbody.velocity;
        velocity.x = horizontal*speed;
      rigidbody.velocity= velocity;



    }
    public void ApplyDeath(float DammageDealt)
    {
        health = health - DammageDealt;
    }
}
