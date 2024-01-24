using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SeanJ
{
	public class BoardCreator : MonoBehaviour
	{


        // script instantiates tiles, thus making the game board


        #region Public Fields

        [Header("Prefab"), Tooltip("The tile prefab to spawn")]
        public Tile tilePrefab;

        [Header("Boardsize"), Tooltip("The size of the board. Must be odd")]
        public Vector2Int boardSize = new Vector2Int(11, 11);

        [Header("Tile Materials"), Tooltip("0 = even, 1= odd, 2= special")]
        public Material[] tileMaterials = new Material[3];

        #endregion

        #region Private Fields

        #endregion

        #region Events

        #endregion

        #region Monobehavior Callbacks

        private void Start()
        {
            CreateBoard(boardSize, tilePrefab, tileMaterials);
        }

        #endregion

        #region Event Handlers

        #endregion

        #region Private Functions

        private void CreateBoard(Vector2Int boardSize, Tile prefab, Material[] materials)
        {
            for(int x = 0; x < boardSize.x; x++)
            {
                for(int z = 0; z < boardSize.y; z++)
                {
                    Vector3 spawnPos = new Vector3(x, 0, z);
                    Tile t = Instantiate(prefab, spawnPos, Quaternion.identity, this.transform);
                    if(x == boardSize.x / 2 && z==boardSize.y / 2)
                    {
                        t.myRenderer.material = tileMaterials[2];
                    }
                    else if(x == 0 && z == 0 ||
                        x == 0 && z == boardSize.y - 1 ||
                        x == boardSize.x - 1 && z == boardSize.y - 1 ||
                        x == boardSize.x - 1 && z == 0 )
                    {
                        //first lower left, go clockwise from there
                        //assign "special" material
                        t.myRenderer.material = tileMaterials[2];
                    }
                    else
                    {
                        if(x % 2 == 0 && z % 2 == 0)
                        {
                            //assign even material
                            t.myRenderer.material = tileMaterials[0];
                        }
                        else if(x % 2 == 1 && z % 2 == 1)
                        {
                            //assigns odd material
                            t.myRenderer = tileMaterials[1];
                        }
                    }
                }
            }
        }

        #endregion

        #region Public Functions

        #endregion
    }
}