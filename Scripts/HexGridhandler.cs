using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGridhandler : MonoBehaviour
{

    [SerializeField] private Transform pfsquare;

    private GridXZ<GridObject> gridXZ;
    // Start is called before the first frame update

        private class GridObject
    {

    }
   private void Awake()
    {
        int width = 10;
        int height = 6;
        float cellsize = 1f;
        gridXZ =
            new GridXZ<GridObject>(width, height, cellsize, Vector3.zero,(GridXZ<GridObject> g, int x, int y) => new GridObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
