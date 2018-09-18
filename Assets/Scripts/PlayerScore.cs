using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerScore {

    private static int score;

    public static void setScore(int s)
    {
        score = s;
    }

    public static int getScore()
    {
        return score;
    }
}
