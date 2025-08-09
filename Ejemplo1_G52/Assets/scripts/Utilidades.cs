using System.Collections.Generic;
using System.IO;
using UnityEngine;
using packagePersona;
using packagePunto;

public class Utilidades : MonoBehaviour
{
    public List<Estudiante> estudiantes = new List<Estudiante>();
    public List<Punto2D> puntos = new List<Punto2D>();

    public void GuardarEstudiantesJSON()
    {
        string ruta = Application.persistentDataPath + "/estudiantes.json";
        string json = JsonUtility.ToJson(new ListaEstudiantes(estudiantes), true);
        File.WriteAllText(ruta, json);
        Debug.Log("Archivo estudiantes.json guardado en: " + ruta);
    }

    public void GuardarPuntosJSON()
    {
        string ruta = Application.persistentDataPath + "/puntos.json";
        string json = JsonUtility.ToJson(new ListaPuntos(puntos), true);
        File.WriteAllText(ruta, json);
        Debug.Log("Archivo puntos.json guardado en: " + ruta);
    }

    [System.Serializable]
    private class ListaEstudiantes
    {
        public List<Estudiante> lista;
        public ListaEstudiantes(List<Estudiante> lista) { this.lista = lista; }
    }

    [System.Serializable]
    private class ListaPuntos
    {
        public List<Punto2D> lista;
        public ListaPuntos(List<Punto2D> lista) { this.lista = lista; }
    }
}
