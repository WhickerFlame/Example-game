using UnityEngine;
using System.Collections;

public class Doomba : MonoBehaviour {
    public float dammage = 2;
    void OnCollisionEnter2D(Collision2D collision)

    {
       
Debug.Log("OWWW!!!!");
        Player mario = collision.collider.GetComponent<Player>();
        mario.ApplyDeath(dammage);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
   
	
	}
}
