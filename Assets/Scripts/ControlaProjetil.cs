using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaProjetil : MonoBehaviour
{
    private float _velocidade = 20,_tempoDoProjetilEmCena;
    private Rigidbody ProjetilRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ProjetilRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ProjetilRigidbody.MovePosition(ProjetilRigidbody.position
            +transform.forward*_velocidade*Time.deltaTime);

        
        _tempoDoProjetilEmCena+=Time.deltaTime;
        if(_tempoDoProjetilEmCena>6.0f)    
            Destroy(gameObject);
    }
}
