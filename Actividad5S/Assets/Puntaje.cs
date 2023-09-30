using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puntaje : MonoBehaviour
{
    public Text puntos;
    public int monedas;


    private void Update()
    {
         puntos.text = monedas.ToString();
    }

    public void Agarrar()
    {
        monedas += 1;
    }

}
