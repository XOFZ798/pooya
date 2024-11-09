using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int height = 2;            
    public int width = 2;                
    public float rotationSpeed = 50f;        public Color cubeColor = Color.red;      public Vector3 initialPosition = new Vector3(0, 1, 0); 

    // Start is called before the first frame update
    void Start()
    {
        // Set initial color and position of the cube
        GetComponent<Renderer>().material.color = cubeColor;
        transform.position = initialPosition;
        
        // Adjust the size of the cube using height and width
        transform.localScale = new Vector3(width, height, width);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube around the y-axis based on rotation speed
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
