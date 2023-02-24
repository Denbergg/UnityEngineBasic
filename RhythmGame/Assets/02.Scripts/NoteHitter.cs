using System.Collections;
using UnityEditor;
using UnityEngine;

public class NoteHitter : MonoBehaviour
{
    public enum HitJudge
    {
        None,
        Bad,
        Miss,
        Good,
        Great,
        Cool
    }
    [SerializeField] private KeyCode _key;
    [SerializeField] private LayerMask _hitMask;
    private SpriteRenderer _spriteRenderer;
    private Color _colorOrigin;
    [SerializeField] private Color _colorPressed;
    
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _colorOrigin = _spriteRenderer.color;
    }

    private void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            _spriteRenderer.color = _colorPressed;
            _hitEffect.SetActive(true);
        }

        if (Input.GetKeyUp(_key))
        {
            _spriteRenderer.color = _colorOrigin;
            _hitEffect.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(transform.lossyScale.x / 2.0f)),
                                                            PlaySettings.HIT_JUDGE_RANGE_MISS,
                                                            0.0f));
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(transform.lossyScale.x / 2.0f)),
                                                            PlaySettings.HIT_JUDGE_RANGE_GOOD,
                                                            0.0f));
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(transform.lossyScale.x / 2.0f)),
                                                            PlaySettings.HIT_JUDGE_RANGE_GREAT,
                                                            0.0f));
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(transform.lossyScale.x / 2.0f)),
                                                            PlaySettings.HIT_JUDGE_RANGE_COOL,
                                                            0.0f));
    }
}