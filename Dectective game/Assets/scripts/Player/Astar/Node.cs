using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node 
{
    public bool canTravel;

    int gCost;
    public int GCost
    {
        get
        {
            return gCost;
        }

        set
        {
            gCost = value;
        }
    }

    int hCost;
    public int HCost
    {
        get
        {
            return hCost;
        }

        set
        {
            hCost = value;
        }
    }

    public int FCost
    {
        get
        {
            return GCost + HCost;
        }
    }

    public Node parent;

    public Vector2Int gridPosition
    {
        get;
        private set;
    }

    public Vector2 worldPosition
    {
        get;
        private set;
    }

    public Node(Vector2Int gridPosition, Vector2 Position, bool traversable)
    {
        this.gridPosition = gridPosition;
        this.worldPosition = Position;
        this.canTravel = traversable;
    }

    public void ResetNode()
    {
        GCost = 0;
        HCost = 0;
        parent = null;
    }

    public int CompareTo(object obj)
    {
        Node node = obj as Node;

        if (node.FCost < FCost)
        {
            return 1;
        }

        if (node.FCost > FCost)
        {
            return -1;
        }

        return 0;
    }

}
