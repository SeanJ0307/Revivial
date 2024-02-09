using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private const float TILE_SIZE = 1.0f;
    private const float TILE_OFFSET = 0.5F;

    private int selectionX = -1;
    private int selectionY = -1;

    // Update is called once per frame
    void Update()
    {
        UpdateSelection();
        DrawChessBoard();
    }

    private void UpdateSelection()
    {
        if(!Camera.main)
            return;

        RaycastHit hit;
      //if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,25.0f.)))
    }

    private void DrawChessBoard()
    {
        Vector3 widthLine = Vector3.right * 13;
        Vector3 heightLine = Vector3.forward * 13;

        for (int i = 0; i < 13; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + widthLine);
            for (int j = 0; j < 13; j++)
            {
                start = Vector3.right * j;
                Debug.DrawLine(start, start + heightLine);
            }
        }
    }
}
