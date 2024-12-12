using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
	[SerializeField]
	private GameObject content;
	public static int pipeScore;
	public static int mosquitoScore;
	private Rigidbody2D rb2d;
	private Collider2D[] colliders;
	void Start()
	{
		pipeScore = 0;
		mosquitoScore = 0;
		rb2d = this.GetComponent<Rigidbody2D>();
		colliders = this.GetComponents<Collider2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.timeScale == 0) return;  // Do not move the bird when the game is paused.

		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb2d.AddForce(Vector2.up * 300);
		}
		this.transform.eulerAngles = new Vector3(0, 0, rb2d.linearVelocityY * 2.5f);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Pipe"))
		{
			content.SetActive(true);
			Time.timeScale = content.activeInHierarchy ? 0.0f : 1.0f;
			ModalScript.onPause = false;
			content.transform.Find("ContentPause").gameObject.SetActive(false);
			content.transform.Find("ContentGameOver").gameObject.SetActive(true);
		}

	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Pipe"))
		{
			if (!colliders.Any(c => c.IsTouching(collision)))
			{
				pipeScore++;
				Debug.Log(" + 1 Pipe");
			}
		}
		if (collision.gameObject.CompareTag("Mosquito"))
		{
			if (colliders.Any(c => c.IsTouching(collision)))
			{
				mosquitoScore++;
				collision.gameObject.SetActive(false);
				Debug.Log(" + 1 Mosquito");
			}
		}
	}
}
