using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLogicaTresEnRaya : MonoBehaviour
{
    [SerializeField] 
    private GameObject XPiece;
    [SerializeField]
    private GameObject OPiece;

    int turno = 1;
    private int[,] board = new int[3,3];
    private void Start()
    {
        InicializarTablero();
    }

    void InicializarTablero()
    {
        for (int i = 0; i < 3; i ++)
        {
            for(int j = 0; j < 3; j ++)
                board[i,j] = -1;
        }
    }

    private bool CompruebaGanadorfilas()
    {
        //filas 
        for( int i = 0;i < 3;i++)
           if (board[0, i] == board[1, i]  )
            {
                if (board[1, i] == board[2, i])
                {
                    return true; 
                }
            }

        return false;
        
        

        //Columnas
    }
    void movimientos() 
    
    { 
    }



}//MAIN
