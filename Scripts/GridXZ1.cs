using System;
using UnityEngine;

internal class GridXZ<T> : GridXZ
{
    private int width;
    private int height;
    private float cellsize;
    private Vector3 zero;
    private Func<GridXZ<GridObject>, int, int, GridObject> p;

    public GridXZ(int width, int height, float cellsize, Vector3 zero, Func<GridXZ<GridObject>, int, int, GridObject> p)
    {
        this.width = width;
        this.height = height;
        this.cellsize = cellsize;
        this.zero = zero;
        this.p = p;
    }
}