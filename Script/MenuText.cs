using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
    public Text spaceText;
    public Text pressText;
    public Text jumpText;
    public Text toText;
    public Vector3 maxScale;
    public Vector3 minScale;
    public float scalingSpeed;
    public float sclaingDuration;
    public bool repeatFlag;

    private IEnumerator Start()
    {
        while(repeatFlag)
        {
            yield return RepeatLerping(minScale, maxScale, sclaingDuration);
            yield return RepeatLerping(maxScale, minScale, sclaingDuration);
        }
    }

    IEnumerator RepeatLerping(Vector3 minScale, Vector3 maxScale, float time)
        {
            float t = 0.0f;
            float rate = (1f / time) * scalingSpeed;
            while(t<1f)
            {
                t += Time.deltaTime * rate;
                transform.localScale = Vector3.Lerp(minScale, maxScale, t);
                yield return null;
            }

        }
}
