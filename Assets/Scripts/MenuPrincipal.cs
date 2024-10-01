using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void CargarDosJugadores()
    {
        print("CargarDosJugadores ejecutada");
        SceneManager.LoadScene("2Jugadores");
    }
    public void CargarUnJugador()
    {
        print("CargarUnJugador ejecutada");
        SceneManager.LoadScene("1Jugador");
    }
    public void Salir()
    {
        print("Salir ejecutada");
        Application.Quit();
    }
}
