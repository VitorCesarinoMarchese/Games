using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bola : MonoBehaviour
{

    public float velocidadeDaBola;
    public Rigidbody2D oRigidbody2D;
    public bool bola1;
    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start()
    {
        if (bola1)
        {
            oRigidbody2D.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola) * Time.deltaTime;
        }

        if (!bola1)
        {
            oRigidbody2D.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola) * Time.deltaTime*-1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        somDaBola.Play();
    }      

    
}
