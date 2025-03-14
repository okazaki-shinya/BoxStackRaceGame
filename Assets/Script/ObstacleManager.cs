using UnityEngine;

public class ObstacleManager : MonoBehaviour {
    private PlayerMove _playerMove;

    private void OnCollisionEnter(Collision collision) {
        // �e�I�u�W�F�N�g�i�v���C���[�j���擾
        _playerMove = collision.gameObject.GetComponent<PlayerMove>();

        if (_playerMove != null) {
            // �v���C���[�{�̂ɓ��������Ƃ��i�e�I�u�W�F�N�g��Collider�ɓ��������ꍇ�j
            if (collision.collider.transform == collision.gameObject.transform) {
                GameManager.GameOver = true;
                return;
            }

            // ���u���b�N�ɓ���������
            collision.collider.transform.parent = null;
        }
    }
}

