using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{
    public GameObject Projetil;
    public GameObject PosicaoDoProjetil;
    [SerializeField]
    private float tempo,tempoPorDisparo = 0.5f;
    //public AudioClip SomDoDisparo;
    void Update()
    {
        tempo += Time.deltaTime;
        if (Input.GetMouseButton(0) && tempo >= tempoPorDisparo)
        {
            Instantiate(Projetil, PosicaoDoProjetil.transform.position, PosicaoDoProjetil.transform.rotation);
            tempo = 0;
            //Falta implementar o audio do disparo
        }
    }
}
