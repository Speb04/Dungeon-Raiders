using UnityEngine;

public class Bats : MonoBehaviour
{
    public BatScript[] prefabs;
    
    public int rows = 5; //number of bats going up

    public int columns = 11; //number of bats across
    
    public float speed = 10.0f; //speed

    private Vector3 _direction = Vector2.right; //moves bats right

    private void Awake()
    {
        for (int row = 0; row < this.rows; row++)
        {
            //creates a grids for the bats to be placed into
            float width = 8.0f * (this.columns - 1);
            float height = 8.0f * (this.rows - 1);
            Vector2 centering = new Vector2(-width / 2, -height /2);
            Vector3 rowPosition = new Vector3(centering.x, centering.y + (row * 8.0f),  0.0f);

            for (int col = 0; col < this.columns; col++)
            {
                //makes an array for the bat prefabs to be placed into a grid, can edit the number of bats spawned in grid through unity inspector
                BatScript bat = Instantiate(this.prefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col * 8.0f;
                bat.transform.localPosition = position; 
            }
        }

    }

    //used to make the Bats move, stops frame rate from having an affect on them

    private void Update()
    {
        this.transform.position += _direction * this.speed * Time.deltaTime;
    }

}
