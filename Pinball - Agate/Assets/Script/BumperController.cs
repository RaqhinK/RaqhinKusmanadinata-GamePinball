using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
	// menyimpan variabel bola sebagai referensi untuk pengecekan
	public Collider bola;

	// untuk mengatur kecepatan bola setelah memantul
	public float multiplier;

	// tambahkan audio manager untuk mengakses fungsi pada audio managernya
	public AudioManager audioManager;
	// tambahkan vfx manager untuk mengakses fungsi pada audio managernya
	public VFXController VFXManager;
	// untuk mengakses score manager
	public ScoreManager scoreManager;

	private void OnCollisionEnter(Collision collision)
	{
		// memastikan yang menabrak adalah bola
		if (collision.collider == bola)
		{

			// kita lakukan debug
			// ambil rigidbody nya lalu kali kecepatannya sebanyak multiplier agar bisa memantul lebih cepat
			Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
			bolaRig.velocity *= multiplier;

			// kita jalankan SFX saat tabrakan dengan bola pada posisi tabrakannya
			audioManager.PlaySFX(collision.transform.position);
			// kita jalankan VFX saat tabrakan dengan bola pada posisi tabrakannya
			VFXManager.PlayVFX(collision.transform.position);
			//tambah score saat menabrak bumper
			scoreManager.AddScore(150);

			// batasi kecepatan pada arah Y agar bola tidak melompat terlalu tinggi
			if (bolaRig.velocity.y > 2f)
			{
				bolaRig.velocity = new Vector3(bolaRig.velocity.x, 2f, bolaRig.velocity.z);
			}
		}
	}
}
