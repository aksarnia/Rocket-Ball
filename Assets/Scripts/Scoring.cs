using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Rocketball.Gameplay;

namespace Rocketball.Scoring
{

    public class Scoring : MonoBehaviour
    {
        [SerializeField] private int scoreIncrement = 100;
        [SerializeField] private int scoreDecrement = 50;
        public static int score = 0;
        
        private void Start()
        {
            
        }

        private void Update()
        {
            
        }

        void OnGUI()
        {
            GUI.Box(new Rect(2150, 100, 500, 50), score.ToString()); // Current Score
            GUI.Box(new Rect(2150, 200, 500, 50), score.ToString()); // Hi-Score
        }

        private void OnCollisionEnter2D(Collision2D collision) 
        {
            if (collision.transform.name == "Tower")
            {
                score += scoreIncrement;
                // Destroy (gameObject);
            }
            else if (collision.transform.name == "Tower (1)")
            {
                score += scoreIncrement;
                // Destroy (gameObject);
            }
            else if (collision.transform.name == "Tower (2)")
            {
                score += scoreIncrement;
                // Destroy (gameObject);
            }
            else if (collision.transform.name == "Tower (3)")
            {
                score += scoreIncrement;
                // Destroy (gameObject);
            }            
            else if (collision.transform.name == "Tower (4)")
            {
                score += scoreIncrement;
                // Destroy (gameObject);
            }
            else if (collision.transform.name == "Tower (5)")
            {
                score += scoreIncrement;
                // Destroy (gameObject);
            }
            else
            {
                score -= scoreDecrement;
                // Destroy (gameObject);
            }
            Destroy (gameObject);
        }
    }
}