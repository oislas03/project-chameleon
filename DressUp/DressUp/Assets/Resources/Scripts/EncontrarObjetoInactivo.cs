using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EncontrarObjetoInactivo {

    /// <summary>
    /// Este método permite encontrar un GameObject inactivo en la escena seleccionada 
    /// </summary>
    /// <param name="parent">GameObject padre que contiene al GameObject buscado</param>
    /// <param name="name">Nombre del GameObject a buscar</param>
    /// <returns></returns>
    static public GameObject EncontrarObjeto(this GameObject parent, string name)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }
}
