using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaProjetil : MonoBehaviour
{
    
    private float _velocidade = 20,_tempoDoProjetilEmCena;
    private Rigidbody ProjetilRigidbody;
    private Vector3 recuo;
    [SerializeField]
    private float nX, pX;
    // Start is called before the first frame update
    void Start()
    {
        ProjetilRigidbody = GetComponent<Rigidbody>();
        recuo.x = Random.Range(nX, pX) * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        ProjetilRigidbody.MovePosition(ProjetilRigidbody.position+recuo
            +transform.forward*_velocidade*Time.deltaTime);


        
          _tempoDoProjetilEmCena+=Time.deltaTime;
         if(_tempoDoProjetilEmCena>15.0f)    
             Destroy(gameObject);
         
    }
}
