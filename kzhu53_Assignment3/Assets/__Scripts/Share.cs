using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour
{
    // Start is called before the first frame update
    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
    private const string TWEET_LANGUAGE = "en";

    public void shareToTwitter()
    {
        string text = "Highscore: ";
        int score = ScoreManager.SCORE;
        Application.OpenURL(TWITTER_ADDRESS +
                    "?text=" + WWW.EscapeURL(text) + score +
                    "&amp:lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
    }
}
