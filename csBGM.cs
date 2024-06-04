using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBGM : MonoBehaviour
{
    public AudioClip start;
    public AudioClip house;
    public AudioClip city;
    public AudioClip forest;

    private AudioSource audioSource;

    public Material citySkybox;
    public Material forestSkybox;

    private void Start()
    {
        // AudioSource ������Ʈ ��������
        audioSource = GetComponent<AudioSource>();

        // ó�� ������ �� ����� A ���
        audioSource.clip = start;
        audioSource.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ��ü�� �÷��̾����� üũ1���� Ȯ��
        if (other.gameObject.name=="intoHouse")
        {
            // ����� A ���߰� ����� B ���
            //RenderSettings.skybox = Sky;
            audioSource.Stop();
            audioSource.clip = house;
            audioSource.Play();
        }
        if (other.gameObject.name == "intoForest")
        {
            // ����� A ���߰� ����� B ���
            RenderSettings.skybox = forestSkybox;
            audioSource.Stop();
            audioSource.clip = forest;
            audioSource.Play();
        }
        if (other.gameObject.name == "intoCity")
        {
            // ����� A ���߰� ����� B ���
            RenderSettings.skybox = citySkybox;
            audioSource.Stop();
            audioSource.clip = city;
            audioSource.Play();
        }
    }
}
