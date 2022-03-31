using UnityEngine;

public class Bats : MonoBehaviour
{
    public BatScript[] prefabs;
    
    public int rows = 5;

    public int columns = 11;

    private void Awake()
    {
        for (int row = 0; row < this.rows; row++)
        {
            float width = 8.0f * (this.columns - 1);
            float height = 8.0f * (this.rows - 1);
            Vector2 centering = new Vector2(-width / 2, -height /2);
            Vector3 rowPosition = new Vector3(centering.x, centering.y + (row * 8.0f),  0.0f);

            for (int col = 0; col < this.columns; col++)
            {
                BatScript bat = Instantiate(this.prefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col * 8.0f;
                bat.transform.localPosition = position; 
            }
        }

    }
}
