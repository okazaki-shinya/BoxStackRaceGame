using UnityEngine;

public class BoxGetManager : MonoBehaviour {
    [SerializeField] private GameObject _player = null;
    [SerializeField] private GameObject _box = null;
    [SerializeField] private float _boxSize = 1f;
    [SerializeField] private float _boxSpawnOffset = 1f;

    private BoxItem_Temp _boxItemScript = null;

    private int _boxNum = 0;

    private void OnTriggerEnter(Collider other) {
        _boxItemScript = other.gameObject.GetComponent<BoxItem_Temp>();

        if (_boxItemScript != null) {
            Debug.Log("GetBox!!");

            _player.transform.position += transform.up * _boxSize;

            Vector3 spawnPosition = _player.transform.position - transform.up * _boxSize * _boxNum - transform.up * _boxSpawnOffset;

            _boxNum++;

            Destroy(other.gameObject);
        }
    }
}
