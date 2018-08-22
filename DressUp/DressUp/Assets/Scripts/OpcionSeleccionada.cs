using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpcionSeleccionada : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CambiarFondo(string nombreFondo)
    {
        nombreFondo = "fondo2.jpeg";
        GameObject obj = GameObject.Find("Fondo");

        Image imagen = obj.GetComponent<Image>();
        Sprite sprite = Resources.Load("Sprites/" + nombreFondo + ".png") as Sprite;
        
        imagen.sprite = sprite;
    }
}
