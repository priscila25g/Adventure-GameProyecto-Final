using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionUsuarios : MonoBehaviour
{
    [Header("Campos para Registro")]
    public TMP_InputField[] campos_registro;

    [Header("Campos Inicio")]
    public TMP_InputField[] campos_inicio;

    [Header("Sistema Alertas")]
    public string[] texto_alertas;

    public GameObject panel_Alerta;
    public TMP_Text alerta_Actual;
    public void RegistrarUsuario()
    {
        for (int i = 0; i < campos_registro.Length; i++)
        {
            //Primer alerta campos vacios.
            if (string.IsNullOrEmpty(campos_registro[i].text))
            {
                panel_Alerta.SetActive(true);
                alerta_Actual.text = texto_alertas[0];
                return;
            }
            else
            {
                if (Manager.instance.usuarios.Contains(campos_registro[0].text))
                {
                    //Segunda alerta
                    panel_Alerta.SetActive(true);
                    alerta_Actual.text = texto_alertas[1];
                    return;
                }
                else
                {
                    StartCoroutine(setUser());
                }
            }
        }

    }
    IEnumerator setUser()
    {
        print("se esta creando el usuario");
        alerta_Actual.text = texto_alertas[4];
        panel_Alerta.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Manager.instance.usuarios.Add(campos_registro[0].text);
        Manager.instance.nombre_usuarioActual = campos_registro[0].text;
        Manager.instance.correo_usuarioActual = campos_registro[1].text;
        Manager.instance.contraseña_usuarioActual = campos_registro[2].text;
        CambioEscena cambioEscena = FindObjectOfType<CambioEscena>();
        cambioEscena.CambiarEscena("Principal");
    }

    public void IniciarSesion()
    {
        for (int i = 0; i < campos_inicio.Length; i++)
        {
            //Primer alerta campos vacios.
            if (string.IsNullOrEmpty(campos_inicio[i].text))
            {
                panel_Alerta.SetActive(true);
                alerta_Actual.text = texto_alertas[0];
            }
            else
            {
                if (Manager.instance.usuarios.Contains(campos_inicio[0].text))
                { 
                    Manager.instance.nombre_usuarioActual = campos_inicio[0].text;
                    Manager.instance.correo_usuarioActual = campos_inicio[1].text;
                    Manager.instance.contraseña_usuarioActual = campos_registro[2].text;

                    CambioEscena cambioEscena = FindObjectOfType<CambioEscena>();
                    cambioEscena.CambiarEscena("Principal");
                }
                else
                {
                    //Tercer Alerta
                    panel_Alerta.SetActive(true);
                    alerta_Actual.text = texto_alertas[2];
                }
            }
        }

    }


}
