using UnityEngine;
using System.Collections;
using Leap;

public class PalmUp : MonoBehaviour {
    Controller controller;
    Frame frame;
    HandList hands;
    Hand hand;
	// Use this for initialization
	void Start () {
        controller = new Controller();
        
	}

    // Update is called once per frame
    void Update() {
        frame = controller.Frame();
        hands = frame.Hands;
        if (hands.IsEmpty)
            return;
        hand = hands[0];
        if (hand.IsValid) { 
        Debug.Log(hand.PalmNormal);
    }
	}
}
