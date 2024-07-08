using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PotionBoard : MonoBehaviour
{
    //define the size of the board
    public int Width = 6;
    public int Height = 8;
    //define some spacing for the board 
    public float SpacingX;
    public float SpacingY;
    //get a refrence to our potion prefabs
    public GameObject[] potionPrefabs;
    //get a refrence to the collection nodes potionboard + GameObject
    public Node[,] potionBoard;
    public GameObject potionBoardGo;


    //layoutArray
    public ArrayLayout arrayLayout;
    //public static of potionboard
    public static PotionBoard Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        InitialzeBoard();
    }
    void InitialzeBoard()
    {
        potionBoard = new Node[Width, Height];

        SpacingX = (float)(Width - 1) / 2;
        SpacingY = (float)(Height - 1) / 2;

        //these for loops used for making potion in a  matris mode

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector2 position = new Vector2(x - SpacingX, y - SpacingY);

                if (arrayLayout.rows == null || arrayLayout.rows.Length <= y || arrayLayout.rows[y].row == null || arrayLayout.rows[y].row.Length <= x)
                {
                    Debug.LogError($"ArrayLayout rows are not properly set at position ({x}, {y})!");
                    continue;
                }
                if (arrayLayout.rows[y].row[x])
                {
                    potionBoard[x, y] = new Node(false, null);
                }
                else
                {
                    int randomIndex = Random.Range(0, potionPrefabs.Length);

                    GameObject potion = Instantiate(potionPrefabs[randomIndex], position, Quaternion.identity);

                    potion.GetComponent<Potion>().SetIndicies(x, y);
                    potionBoard[x, y] = new Node(true, potion);
                }

            }
        }
    }
}
