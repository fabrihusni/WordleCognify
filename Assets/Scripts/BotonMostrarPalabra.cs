using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BotonMostrarPalabra : MonoBehaviour
{
    public GameObject mostrarPalabra;
    public TMP_Text PalabraText;
    public Board board;
    public void OnButtonClick()
    {
        PalabraText.text = board.word.ToString();
        PalabraText.gameObject.SetActive(true);
        
    }

  


}
