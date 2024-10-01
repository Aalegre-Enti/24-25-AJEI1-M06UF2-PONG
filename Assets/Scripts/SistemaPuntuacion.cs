using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaPuntuacion : MonoBehaviour
{
    public int puntuacionA;
    public TMP_Text puntuacionAtexto;
    public int puntuacionB;
    public TMP_Text puntuacionBtexto;

    void Update()
    {
        puntuacionAtexto.text = puntuacionA.ToString();
        puntuacionBtexto.text = puntuacionB.ToString();

        //OR
        if (puntuacionA > 9 || puntuacionB > 9)
        {
            SceneManager.LoadScene("MenuPrincipal");
        }
        //AND
        //if (puntuacionA > 9 && puntuacionB > 9)
        //{

        //}
    }
}
