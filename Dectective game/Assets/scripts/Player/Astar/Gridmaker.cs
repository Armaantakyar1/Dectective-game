using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmaker : MonoBehaviour
{
    [SerializeField] GameObject cube;
    public int sizeX = 5;
    public int sizeY = 5;
    [SerializeField] float cellWidth;
    [SerializeField] float cellHeight;
    public Node[] nodes;

    void Start()
    {
        nodes = new Node[sizeX * sizeY];
        Generate();

    }
    void Generate()
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int x = 0; x < sizeX; x++)
            {
                int i = x + y * sizeX;
                Vector2Int position = new Vector2Int(x,y);
                Vector2 nodeGridWorldPosition = new Vector2(x * cellWidth - cellWidth / 2, y * cellHeight * cellHeight / 2);
                bool walkable = Physics2D.OverlapCircle(nodeGridWorldPosition, sizeY / 4) == null;
                nodes[i] = new Node(position, nodeGridWorldPosition, walkable);


            }
        }
    }

    public Node GetNode(Vector2Int position)
    {
        int i = position.x + position.y * sizeX;
        return nodes[i];
    }

    public Vector2Int Getposition(Vector2 worldPosition)
    {
        return new Vector2Int(
            (int)((worldPosition.x + cellWidth) / cellWidth),
            (int)((worldPosition.y + cellHeight) / cellHeight)
            );
    }

}