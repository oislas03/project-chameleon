using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenu : MonoBehaviour {

    public GameObject infoGuardar;
    public GameObject infoBio;
    public GameObject bio;

    ManejadorDatos manager;
    string guardarCargar;
    Personaje p;
	// Use this for initialization
	void Start () {
        manager = new ManejadorDatos();
        p = new Personaje();

        int valor = GameObject.Find("Menu").GetComponent<Dropdown>().value;

         GameObject.Find("Menu").GetComponent<Dropdown>().options[valor].image=null;

    }


	
	// Update is called once per frame
	void Update () {
		
	}


    //Se activa cuando se da click sobre alguno de los botones del menu desplegable
    public void cambioMenu () {

        int valor = GameObject.Find("Menu").GetComponent<Dropdown>().value;

        string valorReal =GameObject.Find("Menu").GetComponent<Dropdown>().options[valor].text;


        switch (valorReal)
        {
            case "Save":
                guardarCargar = "guardar";
                infoGuardar.SetActive(true);
                GameObject.Find("textoSave1").GetComponent<Text>().text = "SAVE CHARACTER";
                GameObject.Find("textoSave2").GetComponent<Text>().text = "If you save over an used slot  the old version will be replaced.";
                break;
            case "Load":
                guardarCargar = "cargar";
                infoGuardar.SetActive(true);
                GameObject.Find("textoSave1").GetComponent<Text>().text = "LOAD CHARACTER";
                GameObject.Find("textoSave2").GetComponent<Text>().text = "Load your character.";

                break;
            case "Share":
                break;
            case "FullScreen":
                break;
            case "Bio":

                infoBio.SetActive(true);
                GameObject.Find("infoBio").transform.Find("InputName").GetComponent<InputField>().text =p.Name==""?"Name":p.Name;
                 GameObject.Find("infoBio").transform.Find("InputAge").GetComponent<InputField>().text=p.Edad == "" ? "Age" : p.Edad; 
                GameObject.Find("infoBio").transform.Find("InputLikes").GetComponent<InputField>().text= p.Gustos == "" ? "Likes" : p.Gustos; 
                GameObject.Find("infoBio").transform.Find("InputDislikes").GetComponent<InputField>().text= p.Disgustos == "" ? "Dislikes" : p.Disgustos; 
                GameObject.Find("infoBio").transform.Find("InputSummary").GetComponent<InputField>().text = p.Resumen == "" ? "Summary" : p.Resumen;
                break;
            default: break;
        }

    }

    public void guardarBio() {
        this.p.Name = GameObject.Find("infoBio").transform.Find("InputName").GetComponent<InputField>().text;
       this.p.Edad = GameObject.Find("infoBio").transform.Find("InputAge").GetComponent<InputField>().text;
        this.p.Gustos = GameObject.Find("infoBio").transform.Find("InputLikes").GetComponent<InputField>().text;
        this.p.Disgustos = GameObject.Find("infoBio").transform.Find("InputDislikes").GetComponent<InputField>().text;
        this.p.Resumen = GameObject.Find("infoBio").transform.Find("InputSummary").GetComponent<InputField>().text;

        bio.SetActive(true);
        GameObject.Find("Bio").transform.Find("TextName").GetComponent<Text>().text = p.Name;
        GameObject.Find("Bio").transform.Find("TextAge").GetComponent<Text>().text = p.Edad;
        GameObject.Find("Bio").transform.Find("TextLikes").GetComponent<Text>().text = p.Gustos;
        GameObject.Find("Bio").transform.Find("TextDislikes").GetComponent<Text>().text = p.Disgustos;
        GameObject.Find("Bio").transform.Find("TextSummary").GetComponent<Text>().text = p.Resumen;
        cerrar();

    }


    //Metodo que permite guardar o cargar un p
    public void guardarCargarPersonaje(int indiceSlot)
    {



        if (guardarCargar.Equals("guardar"))
        {  
            //Construir personaje a base de los assets cargados en la pantalla
            Personaje p = new Personaje("Maria");

            //Mandar a llamar al metodo que guarda
            manager.guardar(p, 1);

        }
        else if (guardarCargar.Equals("cargar")) {
            Personaje p = manager.Cargar(1);

            string nombre = p == null ? "No hay personajes guardados" : p.Name; 
            Debug.Log(nombre);

        }

        //Se aplica cuando se va a cerrar la pestaña del menu, siempre
        cerrar();
        
    }

    public void cerrar() {
        infoGuardar.SetActive(false);
        infoBio.SetActive(false);
      int  v=  GameObject.Find("Menu").GetComponent<Dropdown>().value = 5;
        GameObject.Find("Menu").GetComponent<Dropdown>().options[v].image=null;

    }


    private void construirPersonaje() {
        //Personaje p = new Personaje();


        string camiseta = GameObject.Find("camiseta").GetComponent<Image>().name;
        string boca = GameObject.Find("boca").GetComponent<Image>().name;
        string ojos = GameObject.Find("ojos").GetComponent<Image>().name;
        string zapatos = GameObject.Find("zapatos").GetComponent<Image>().name;
        string cachetes = GameObject.Find("cachetes").GetComponent<Image>().name;
        string orejas = GameObject.Find("orejas").GetComponent<Image>().name;
        string gorro = GameObject.Find("camiseta").GetComponent<Image>().name;
        string pantalones = GameObject.Find("camiseta").GetComponent<Image>().name;
        string cabelloAtras = GameObject.Find("cabelloAtras").GetComponent<Image>().name;



    }




}
