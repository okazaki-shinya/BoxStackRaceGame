using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private GameObject _player;      // 追従するプレイヤー

    [Header("カメラオフセット")]
    [SerializeField] private float _offsetX = 0f;
    [SerializeField] private float _offsetY = 5f;
    [SerializeField] private float _offsetZ = -10f;

    [Space]
    [SerializeField] private float _smoothSpeed = 5f;                  // カメラ移動のスムーズさ

    private Vector3 _cameraTarget;

    private Vector3 _cameraOffset;

    private BoxGetManager _boxGetManager;

    private void Start() {
        _cameraTarget = _player.transform.position;

        _cameraOffset = new Vector3(_offsetX, _offsetY, _offsetZ);

        _boxGetManager = _player.GetComponent<BoxGetManager>();
    }

    void LateUpdate() {
        if (_player == null) return;

        // 目標の位置（プレイヤーの位置 + 固定のオフセット）
        _cameraTarget.z = _player.transform.position.z;
        Vector3 targetPosition = _cameraTarget + _cameraOffset * (1f + 0.1f * _boxGetManager.BoxNum);

        // 補間を使ってスムーズに移動
        transform.position = Vector3.Lerp(transform.position, targetPosition, _smoothSpeed * Time.deltaTime);

        // プレイヤーを見つめる
        transform.LookAt(_cameraTarget);
    }
}
