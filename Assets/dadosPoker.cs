using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadosPoker : MonoBehaviour
{
    // Start is called before the first frame update
    char[] dadosValor = { '7', '8', 'J', 'Q', 'K', 'A' };
    char[] dados = new char[6];
    public int tiradas = 0;
    public bool reset = false;
    public bool[] dadosSeleccion = new bool[6];
    public bool tiraDados = false;
    string tiradaDados = null;
    void Start()
    {
        tiradas = 0;
        dadosSeleccion = new bool[] {true,true,true,true,true,true};
    }

    // Update is called once per frame
    void Update()
    {
        if (reset)
        {
            tiradas = 0;
            dadosSeleccion = new bool[] { true, true, true, true, true, true };
            reset = false;
        }
        if (tiraDados)
        {
           // print("El valor del dado es: " + dadosValor[Random.Range(0, 5)]);
            tiradas++;
            tiradaDados = null;
            for (int i = 0; i < dadosSeleccion.Length; i++)
            {
                if (dadosSeleccion[i] )
                {
                    dados[i] = dadosValor[Random.Range(0, 5)];
                    
                }
                if (i < dadosSeleccion.Length - 1)
                    tiradaDados += dados[i] + ",";
                else
                    tiradaDados += dados[i];
            }
          
            print("El valor del dado es: " + tiradas + ") " + tiradaDados);
            tiraDados = false;
            
        }
    }
}
