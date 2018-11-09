//John Tucker

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMirrorBounce : MonoBehaviour
{
    public float initialX;
    public float initialY;

    private Vector3 v;

    private int count = 0;

    // Use this for initialization
    void Start()
    {
        v = new Vector3(initialX, initialY);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += v * Time.deltaTime;
        //Debug.Log(count);
    }


    void OnCollisionEnter(Collision col)
    {
        v = Vector3.Reflect(v.normalized, col.transform.forward) * (Mathf.Sqrt(initialX * initialX + initialY * initialY));
        //count++;

        if (col.gameObject.tag != "Mirror") { Destroy(gameObject); }
    }
}
