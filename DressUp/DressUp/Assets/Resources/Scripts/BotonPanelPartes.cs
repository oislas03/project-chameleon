using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPanelPartes : MonoBehaviour {

    GameObject panelAnterior;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MostrarPanel(string nombrePanel)
    {
        // Si hay un panel de opciones activo actualmente, lo esconde
        if(panelAnterior != null)
        {
            panelAnterior.SetActive(false);
        }

        // GameObject que almacenará el panel de opciones que se activará
        GameObject obj;

        // Se activa el panel de opciones cuyo nombre coincida con el parámetro nombrePanel
        switch (nombrePanel)
        {
            case "Cabeza":
                obj = EncontrarObjetoInactivo.EncontrarObjeto(GameObject.Find("PanelOpciones"), "PanelCabezas");
                obj.SetActive(true);
                panelAnterior = obj;
                break;
            case "Ojos":
                break;
            case "Cabello":
                break;
            case "Camisetas":
                obj = EncontrarObjetoInactivo.EncontrarObjeto(GameObject.Find("PanelOpciones"), "PanelCamisetas");
                obj.SetActive(true);
                panelAnterior = obj;
                break;
            case "Sombrero":
                break;
            case "Fondo":
                obj = EncontrarObjetoInactivo.EncontrarObjeto(GameObject.Find("PanelOpciones"), "PanelFondos");
                obj.SetActive(true);
                panelAnterior = obj;
                break;
            default: break;
        }
    }
}
