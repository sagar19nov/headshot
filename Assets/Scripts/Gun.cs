using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public Rigidbody bullet;
    public float speed;

    public int maxMagSize;
    public int mag;
    // Start is called before the first frame update
    void Start()
    {
        mag = maxMagSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 100 == 0 && mag != 0) {
            Rigidbody clone;
            clone = Instantiate(bullet, transform.position, transform.rotation);
            clone.velocity = new Vector3(0, 0, 10);
            --mag;
        }
    }
}
