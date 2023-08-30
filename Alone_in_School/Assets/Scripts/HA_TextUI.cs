using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class HA_TextUI : MonoBehaviour
{
    public GameObject linesObject;  // �ؽ�Ʈ�� ����� ���� ������Ʈ �Ҵ�
    private TextMesh lines;         // �ؽ�Ʈ�� ����� ���� ������Ʈ���� �ʿ��� ������Ʈ �Ҵ��ϴ� �뵵

    private string[] diglogue;      // ����� �ڸ��� ������ �����ϴ� �迭

    // ����ϴ� �ڸ��� ������ �����ϴ� �迭�� �ε����� �����ϴ� ����
    // �̺�Ʈ���� ������ �޸��ؾ� �� �� *�ٸ� �޼ҵ忡�� �Ȱ��� ������ ����� ���, �ʱ�ȭ ��ġ�� �ָ���, �޼ҵ� ó���� �ʱ�ȭ�� �ϸ� ȣ���� ������ 0���� �ʱ�ȭ �Ǳ� ������ �ε��� ���� �ȵ�*
    private int countEvent0 = 0;
    private int countEvent4 = 0;

    private void Start()
    {
        lines = linesObject.GetComponent<TextMesh>(); // �ؽ�Ʈ ������Ʈ�� TextMesh ������Ʈ�� ã�Ƽ� �Ҵ���
    }

    public void TextEvent0()
    {
        diglogue = new string[] { "...������", "�� �� �ڰ� ������", "�������� �ð��� �������� �� �ں���...", "(å�� ����� ���� �ܴ�)" };
        lines.text = diglogue[countEvent0];

        Color color = lines.color;
        color.a = 255f;
        lines.color = color;

        countEvent0++;
    }

    public void TextEvent2()
    {
        diglogue = new string[] { "...���� â������ �ε帮�� �Ҹ��� �鸰��\n(���� â���� �ٶ���)", "������ ���ڸ����� ������ �Ҹ��� �鸰��...\n(������ ���ڸ��� �ٶ���)" };
        lines.text = diglogue[countEvent0];

        Color color = lines.color;
        color.a = 255f;
        lines.color = color;

        countEvent0++;
    }

    public void TextEvent4()    // �̺�Ʈ���� �޼ҵ� ���� -> �ش� �޼ҵ�� Event4���� �ش��ϴ� �ڸ��� ����ϴ� ������, �ñ׳η� ��µ� ������ �ε��� ��ȣ�� +1 ��
    {
        diglogue = new string[] { "�̰� ���� �Ҹ���?", "�б��� �� ���� �ִ°� ������", "TEST01" }; // �迭�� Event4�� �ʿ��� ��縦 �迭�� ����
        lines.text = diglogue[countEvent4]; // TestMesh�� Text�� countEvent4���� ���� �迭�� �μ��� ����

        // start
        // ���� linesObject�� ���� ������ *��Ȱ��ȭ ������ ���, ó�� Ȱ��ȭ �� �� �̻��� ���� ��µ�*
        // ��簡 ��µ� �� linesObject�� ���������� �ٲٴ� ������ �ʿ���
        Color color = lines.color;
        color.a = 255f;
        lines.color = color;

        countEvent4++;  // ���� ��� ����� ���� countEvent4�� �ϳ��� ������Ŵ

        // ���� �ڸ��� ���� �ð� ��� �� ������� ���Ѵٸ�
        // Invoke("LineOff", 3f);   // 3�� �� LineOff�� ���� �ڸ��� ��������
    }

    public void LineOff()   // �ش� �޼ҵ带 �̿��� �ڸ��� �����ϰ� ���� *�ڸ��� Ȱ��ȭ ���θ� ������ �����ϰ� ���� ��� ����ϼ���*
    {
        Color color = lines.color;
        color.a = 0f;
        lines.color = color;
    }
}
