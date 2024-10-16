using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGameBoard : MonoBehaviour
{
    public GameObject Dice;
    public Transform GameBoard;
    public int width;
    public int height;

    private GridLayoutGroup gridLayout;

    // Start is called before the first frame update
    void Start()
    {
        CreateBoard(width, height);
    }

    void CreateBoard(int width, int height)
    {
        gridLayout = GameBoard.GetComponent<GridLayoutGroup>();
        gridLayout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        gridLayout.constraintCount = width;

        int boardSize = width * height;
        for (int i = 0; i < boardSize; i++)
        {
            Instantiate(Dice, GameBoard);
        }
        
    }
}
