using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BotonMostrarPalabra : MonoBehaviour
{
    public Button mostrarPalabra;
    public TMP_Text mostrarPalabraTXT;
    public TMP_Text PalabraText;
    public Board board;
    public bool IsMostrando = false;
    public void OnButtonClick()
    {
        PalabraText.text = board.word;
        PalabraText.gameObject.SetActive(true);
        if (IsMostrando)
        {
            mostrarPalabraTXT.text = "MOSTRAR PALABRA";
            IsMostrando = false;
            PalabraText.text = "";
        }
        else
        {
            mostrarPalabraTXT.text = "OCULTAR PALABRA";
            IsMostrando = true;
        }
    }

  


}
