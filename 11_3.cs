using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject tilePrefab; // Prefab for the tiles
    public int rows = 2;
    public int columns = 5;
    public float tileSpacing = 1.0f; // Spacing between tiles

    private GameObject[,] grid;

    void Start()
    {
        grid = new GameObject[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Instantiate the tile
                GameObject tile = Instantiate(tilePrefab, new Vector3(j * tileSpacing, 0, -i * tileSpacing), Quaternion.identity);
                tile.name = $"Tile ({i},{j})";

                // Set initial tile color
                Renderer tileRenderer = tile.GetComponent<Renderer>();
                if (tileRenderer != null)
                {
                    tileRenderer.material.color = Color.white;
                }

                // Store tile in grid
                grid[i, j] = tile;
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject clickedTile = hit.collider.gameObject;
                Renderer tileRenderer = clickedTile.GetComponent<Renderer>();
                if (tileRenderer != null)
                {
                    tileRenderer.material.color = Color.red; // Change tile color to red
                }
                Debug.Log("Clicked on: " + clickedTile.name);
            }
        }
    }

    public void ToggleTile(int row, int column, bool isActive)
    {
        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            grid[row, column].SetActive(isActive);
        }
        else
        {
            Debug.LogWarning($"Invalid tile coordinates! Row: {row}, Column: {column}");
        }
    }

    public void ResetTilesColor(Color color)
    {
        foreach (var tile in grid)
        {
            Renderer tileRenderer = tile.GetComponent<Renderer>();
            if (tileRenderer != null)
            {
                tileRenderer.material.color = color;
            }
        }
    }
}
