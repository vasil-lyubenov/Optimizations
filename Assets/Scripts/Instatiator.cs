using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
	public int count = 10;
	public GameObject prefab;

	private void Start()
	{
		for (int i = 0; i < count; i++)
		{
			var instance = Instantiate(prefab);
			instance.transform.position = GetRandomPosition();
			instance.transform.localScale = GetRandomScale();
		}
	}

	private Vector3 GetRandomScale()
	{
		float scale = Random.Range(1.2f, 4f);
		return new Vector3(scale, scale, scale);
	}

	private Vector3 GetRandomPosition()
	{
		return new Vector3(
			Random.Range(-4f, 4f),
			Random.Range(-4f, 4f),
			Random.Range(-4f, 4f));
	}
}