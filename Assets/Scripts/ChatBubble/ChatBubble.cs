using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{

    public static void Create(Transform parent, Vector3 localPosition, string text)
    {
        Transform chatBubbleTransform = Instantiate(GameAssets.i.PrefabChatBubble, parent);
        chatBubbleTransform.localPosition = localPosition;

        chatBubbleTransform.GetComponent<ChatBubble>().Setup(text);

        Destroy(chatBubbleTransform.gameObject, 10f);
    }

    private SpriteRenderer backgroundSpriteRenderer;
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        backgroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("BubbleText").GetComponent<TextMeshPro>();
    }

    private void Setup(string text)
    {
        textMeshPro.SetText(text);
        textMeshPro.ForceMeshUpdate();
        Vector2 textSize = textMeshPro.GetRenderedValues(false);

        Vector2 padding = new Vector2(2f, 1f);
        backgroundSpriteRenderer.size = textSize + padding;

        Vector3 offset = new Vector2(-2.6f, 0f);
        backgroundSpriteRenderer.transform.localPosition = 
            new Vector3(backgroundSpriteRenderer.size.x / 2f, 0f) + offset;
    }
}
