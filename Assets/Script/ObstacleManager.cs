using UnityEngine;

public class ObstacleManager : MonoBehaviour {
    private PlayerMove _playerMove;

    private void OnCollisionEnter(Collision collision) {
        // 親オブジェクト（プレイヤー）を取得
        _playerMove = collision.gameObject.GetComponent<PlayerMove>();

        if (_playerMove != null) {
            // プレイヤー本体に当たったとき（親オブジェクトのColliderに当たった場合）
            if (collision.collider.transform == collision.gameObject.transform) {
                GameManager.GameOver = true;
                return;
            }

            // 足ブロックに当たった時
            collision.collider.transform.parent = null;
        }
    }
}

