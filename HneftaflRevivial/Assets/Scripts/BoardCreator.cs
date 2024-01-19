using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCreator : MonoBehaviour
{
    [Header("Prefab"), Tooltip("The tile prefab to spawn")]
    public class Tile tilePrefab;

    [Header("Boardsize"), Tooltip("The size of the board. Must be odd")]
    public Vector2Int boardsize = new Vector2Int(11, 11);

    public Material[] tileMaterials = new Material[3];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
