using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 角色的位置
    public float smoothSpeed = 0.125f; // 鏡頭移動的速度
    public Vector3 offset; // 攝影機與角色之間固定的距離

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
		transform.position = desiredPosition;

		transform.LookAt(target);
    }

}
