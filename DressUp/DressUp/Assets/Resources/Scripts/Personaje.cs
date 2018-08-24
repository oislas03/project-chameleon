using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje  {

    int boca;
    int ojos;
    int cachetes;
    int cabelloFrente;
    int cabelloAtras;
    string name;
    string edad;
    string gustos;
    string disgustos;
    string resumen;

    public Personaje() { }

    public Personaje(string name) {
        this.Name = name;
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int Boca
    {
        get
        {
            return boca;
        }

        set
        {
            boca = value;
        }
    }

    public int Ojos
    {
        get
        {
            return ojos;
        }

        set
        {
            ojos = value;
        }
    }

    public int Cachetes
    {
        get
        {
            return cachetes;
        }

        set
        {
            cachetes = value;
        }
    }

    public int CabelloFrente
    {
        get
        {
            return cabelloFrente;
        }

        set
        {
            cabelloFrente = value;
        }
    }

    public int CabelloAtras
    {
        get
        {
            return cabelloAtras;
        }

        set
        {
            cabelloAtras = value;
        }
    }

    public string Edad
    {
        get
        {
            return edad;
        }

        set
        {
            edad = value;
        }
    }

    public string Gustos
    {
        get
        {
            return gustos;
        }

        set
        {
            gustos = value;
        }
    }

    public string Disgustos
    {
        get
        {
            return disgustos;
        }

        set
        {
            disgustos = value;
        }
    }

    public string Resumen
    {
        get
        {
            return resumen;
        }

        set
        {
            resumen = value;
        }
    }
}

