using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBounceTEST : MonoBehaviour
{
    private Vector3 v;

	// Use this for initialization
	void Start ()
    {
        v = new Vector3(2f, 0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += v * Time.deltaTime;
    }

    void OnCollisionEnter(Collision col)   //MUST BE SPELLED PERFECTLY >_> ...
    {
        v = Vector3.Reflect(transform.right, col.transform.forward);
    }
}
