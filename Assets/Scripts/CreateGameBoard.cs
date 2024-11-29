using UnityEngine;
using UnityEngine.UI;

public class CreateGameBoard : MonoBehaviour
{
    public GameObject dicePrefab;
    public Transform gameBoard;
    public int width;
    public int height;

    private GridLayoutGroup gridLayout;

    void Start()
    {
        CreateBoard(width, height);
    }

    void CreateBoard(int width, int height)
    {
        gridLayout = gameBoard.GetComponent<GridLayoutGroup>();
        gridLayout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        gridLayout.constraintCount = width;

        int boardSize = width * height;
        for (int i = 0; i < boardSize; i++)
        {
            Instantiate(dicePrefab, gameBoard);
        }
        
    }
}
