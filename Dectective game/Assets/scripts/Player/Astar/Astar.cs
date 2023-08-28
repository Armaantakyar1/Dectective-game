using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astar : MonoBehaviour
{
    public delegate void FoundPath(List<Node> path);
    public FoundPath PathFound;
    [SerializeField] Gridmaker grid;
    Node start;
    Node end;
    Node current;
    List<Node> openList = new List<Node>();
    List<Node> FinalList = new List<Node>();
    List<Node> neighbours = new List<Node>();
    public bool seach;

    private void Update()
    {
        if(seach == true)
        {
            SearchPath();
        }
    }

    void SearchPath()
    {
        current = start;
        current.ResetNode();
        openList.Add(current);
        FinalList.Clear();

        while (true)
        {
            openList.Sort();
            current = openList[0];
            current.canTravel = true;
            if(current == end)
            {
                Path(end);
                FinalList.Reverse();
                if (PathFound != null)
                {
                    PathFound(FinalList);
                }
                seach = false;
                neighbours.Clear();
                openList.Clear();
                break;
            }
            if(current.gridPosition.x -1 >= 0)
            {
                Vector2Int position = current.gridPosition + new Vector2Int(-1, 0);
                neighbours.Add(grid.GetNode(position));
            }
            if (current.gridPosition.x + 1 <grid.sizeX)
            {
                Vector2Int position = current.gridPosition + new Vector2Int(1, 0);
                neighbours.Add(grid.GetNode(position));
            }
            if (current.gridPosition.y + 1 < grid.sizeY)
            {
                Vector2Int position = current.gridPosition + new Vector2Int(0, 1);
                neighbours.Add(grid.GetNode(position));
            }
            if (current.gridPosition.y + 1 <= 0)
            {
                Vector2Int position = current.gridPosition + new Vector2Int(0, -1);
                neighbours.Add(grid.GetNode(position));
            }

            for(int i = 0; i < neighbours.Count; i++)
            {
                int cost = 1 + current.GCost;
                if(cost < current.GCost || !openList.Contains(neighbours[i]))
                {
                    neighbours[i].HCost = CalculateDistance(neighbours[i].gridPosition, end.gridPosition);
                    neighbours[i].GCost = cost;
                    neighbours[i].parent = current;

                    if (!openList.Contains(neighbours[i]))
                    {
                        openList.Add(neighbours[i]);
                    }
                }
            }

            neighbours.Clear();

            if(openList.Count<= 0)
            {
                seach = false;
                break;
            }

        }

    }
    int CalculateDistance(Vector2Int pointA, Vector2Int pointB)
    {
        return Mathf.Abs(pointA.x - pointB.x) + Mathf.Abs(pointA.y - pointB.y);
    }
    void Path(Node node)
    {
        FinalList.Add(node);

        if(node.parent != null)
        {
            Path(node.parent);
        }

    }

}
