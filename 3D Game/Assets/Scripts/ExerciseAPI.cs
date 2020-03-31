using UnityEngine;

public class ExerciseAPI : MonoBehaviour
{
    public SpriteRenderer kid;
    public Transform cam;

    private void Start()
    {
        Cursor.visible = false;

        kid.flipX = true;

        print(Mathf.Floor(1.23456f));

        cam.Rotate(0 , 90 , 0);
    }
}
