using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Humedad : MonoBehaviour
{
    public Slider barraHumedad;
    [SerializeField] public float humedad;
    [SerializeField] float maxHumedad = 100f;
    public Text estaditicaHumedad;
    [SerializeField] Interfaz_controller sliderTemperatura;

    //Referencias
    [SerializeField] Mision mision1;
    [SerializeField] Mision mision2;

    void Start()
    {
        humedad = maxHumedad;
    }
    void Update()
    {
        barraHumedad.value = humedad;
        humedad -= 1f * Time.deltaTime;
        if (humedad <= 0f)
        {
            humedad = 0f;
        }
        if (sliderTemperatura.temperaturaActual >= 0.5f)
        {
            humedad -= 4f * Time.deltaTime;
        }
        estaditicaHumedad.text = ((int)humedad).ToString();
    }
    
    public void AumentoHumedad()
    {
        mision1.DetectarHidratacion40a50();
        mision2.RehidratarTradigrado();
        humedad = maxHumedad;
        //humedad = maxHumedad;
    }

}
