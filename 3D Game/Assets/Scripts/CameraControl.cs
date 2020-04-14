using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform dragon;
    [Header("追蹤速度"), Range(0, 100)]
    public float speed;

    /// <summary>
    /// 追蹤
    /// </summary>
    private void Track()
    {
        Vector3 draPos = dragon.position;
        draPos.y = 60;
        draPos.z -= 5;
        transform.position = Vector3.Lerp(transform.position, draPos, 0.3f * Time.deltaTime * speed);
    }

    private void LateUpdate()
    {
        Track();
    }
}
