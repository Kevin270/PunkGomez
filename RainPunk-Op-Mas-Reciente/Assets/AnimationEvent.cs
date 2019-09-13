using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    public GameObject particulassalta;
    public GameObject particulallave;
    public GameObject particulaMuere;



    //Activa las particulas cuando esta hackeando 
    public void SaltoPre()
    {
        particulassalta.SetActive(true);
    }
    //Desactiva las particulas cuando acaba de hackear
    public void ApagaSalto()
    {
        particulassalta.SetActive(false);
    }
    //Activa las particulas de la llave cuando va a abrir la puerta
    public void particulallaveentra()
    {
        particulallave.SetActive(true);
    }
    //Desactiva las particulas de la llave cuando se va a abrir
    public void particulallaveSale()
    {
        particulallave.SetActive(false);
    }
    //Las particulas cuando muere el jugador
    public void MeMuero()
    {
        particulaMuere.SetActive(true);
    }
}
