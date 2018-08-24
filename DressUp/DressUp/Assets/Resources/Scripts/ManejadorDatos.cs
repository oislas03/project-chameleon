using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorDatos  {

    //Guarda el personaje en el indice indicado
    public void guardar(Personaje p, int slot) {


       // try{
            PlayerPrefs.SetString("slot" + slot, Helper.Serialize<Personaje>(p));

      //  }catch (Exception e) {  }
    }


    //Regresa el personaje si existe, del indice indicado
    public Personaje Cargar(int slot) {


        if (PlayerPrefs.HasKey("slot" + slot))
        {
            return Helper.Deserialize<Personaje>(PlayerPrefs.GetString("slot" + slot));
        }
        else {
            return null;
        }
    }



   

}
