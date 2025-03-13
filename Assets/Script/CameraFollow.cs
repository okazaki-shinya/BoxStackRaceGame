using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private GameObject _player;      // �Ǐ]����v���C���[

    [Header("�J�����I�t�Z�b�g")]
    [SerializeField] private float _offsetX = 0f;
    [SerializeField] private float _offsetY = 5f;
    [SerializeField] private float _offsetZ = -10f;

    [Space]
    [SerializeField] private float _smoothSpeed = 5f;                  // �J�����ړ��̃X���[�Y��

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

        // �ڕW�̈ʒu�i�v���C���[�̈ʒu + �Œ�̃I�t�Z�b�g�j
        _cameraTarget.z = _player.transform.position.z;
        Vector3 targetPosition = _cameraTarget + _cameraOffset * (1f + 0.1f * _boxGetManager.BoxNum);

        // ��Ԃ��g���ăX���[�Y�Ɉړ�
        transform.position = Vector3.Lerp(transform.position, targetPosition, _smoothSpeed * Time.deltaTime);

        // �v���C���[�����߂�
        transform.LookAt(_cameraTarget);
    }
}
