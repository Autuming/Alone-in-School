using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HA_TextUI : MonoBehaviour
{
    public GameObject linesObject;  // �ؽ�Ʈ�� ����� ���� ������Ʈ �Ҵ�
    private TextMesh lines;         // �ؽ�Ʈ�� ����� ���� ������Ʈ���� �ʿ��� ������Ʈ �Ҵ��ϴ� �뵵

    private string[] diglogue;      // ����� �ڸ��� ������ �����ϴ� �迭

    // ����ϴ� �ڸ��� ������ �����ϴ� �迭�� �ε����� �����ϴ� ����
    // �̺�Ʈ���� ������ �޸��ؾ� �� �� *�ٸ� �޼ҵ忡�� �Ȱ��� ������ ����� ���, �ʱ�ȭ ��ġ�� �ָ���, �޼ҵ� ó���� �ʱ�ȭ�� �ϸ� ȣ���� ������ 0���� �ʱ�ȭ �Ǳ� ������ �ε��� ���� �ȵ�*
    private int countEvent4 = 0;

    private void Update()
    {
        lines = linesObject.GetComponent<TextMesh>(); // �ؽ�Ʈ ������Ʈ�� TextMesh ������Ʈ�� ã�Ƽ� �Ҵ���
    }

    public void Event4()    // �̺�Ʈ���� �޼ҵ� ���� -> �ش� �޼ҵ�� Event4���� �ش��ϴ� �ڸ��� ����ϴ� ������, �ñ׳η� ��µ� ������ �ε��� ��ȣ�� +1 ��
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
