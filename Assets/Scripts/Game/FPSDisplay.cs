using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
	[SerializeField] private Text _text;
	private float _fps;

    void Update()
	{
		_fps = 1.0f / Time.deltaTime;
		_text.text = "FPS: " + _fps.ToString();
	}
}
