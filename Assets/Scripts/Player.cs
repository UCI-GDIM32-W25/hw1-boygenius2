using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    // Upon starting the game, set _numSeedsLeft to _numSeeds and _numSeedsPlanted to 0
    private void Start ()
    {
        _numSeedsPlanted = 0;
        _numSeedsLeft = _numSeeds;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Handling player movement
        if (Input.GetKey(KeyCode.W) )
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) )
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) )
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) )
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);

        // Handling seed planting, if the player has at least one seed
        if (Input.GetKeyDown(KeyCode.Space) && _numSeedsLeft > 0)
            PlantSeed();
    }

    // Adds one planted seed to the screen and updates the UI accordingly
    public void PlantSeed ()
    {
        Instantiate(_plantPrefab, _playerTransform.position, new Quaternion() );  // Plants the seed at the player's position
        _plantCountUI.UpdateSeeds(--_numSeedsLeft, ++_numSeedsPlanted);  // Prefixed operators to update these values first and then pass the arguments
    }
}
