using DG.Tweening;
using UnityEngine;

public class CamRot : MonoBehaviour
{
    [SerializeField] private Vector3 axis = Vector3.up;   // 회전 축 (월드 기준)
    [SerializeField] private float cycleSeconds = 10f;    // 한 바퀴 도는 데 걸리는 시간
    
    void Start()
    {
        transform
            .DORotate(transform.eulerAngles + axis.normalized * 360f, cycleSeconds, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}
