using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class UI_Background : MonoBehaviour
    {
        private SpriteRenderer _sprite;

        // Use this for initialization
        void Start()
        {
            _sprite = GetComponent<SpriteRenderer>();
            float cameraHeight = Camera.main.orthographicSize * 2;
            Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
            Vector2 spriteSize = _sprite.sprite.bounds.size;

            Vector2 scale = transform.localScale;
            if (cameraSize.x >= cameraSize.y)
            { // Landscape (or equal)
                scale *= cameraSize.x / spriteSize.x;
            }
            else
            { // Portrait
                scale *= cameraSize.y / spriteSize.y;
            }

            transform.localScale = scale;
        }
    }
}