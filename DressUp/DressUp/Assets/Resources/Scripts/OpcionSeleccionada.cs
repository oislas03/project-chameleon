using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
        GameObject obj = GameObject.Find("Fondo");

        Image imagen = obj.GetComponent<Image>();

        Sprite sprite = Resources.Load("fondo1", typeof(Sprite)) as Sprite;
        imagen.sprite = sprite;

        Debug.Log(sprite.name+"");

    }


    /**
     * Metodo que sirve para cambiar items estaticos
     * */
    public void CambiarItem(string categoria)
    {
        string nombre = EventSystem.current.currentSelectedGameObject.name;

        GameObject obj = GameObject.Find(categoria);

        Image imagen = obj.GetComponent<Image>();

        Sprite sprite = Resources.Load("Sprites/" + categoria + "/" + nombre, typeof(Sprite)) as Sprite;

       imagen.sprite = sprite;

    }

    public void popo() { }

}
